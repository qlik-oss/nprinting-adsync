using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ADSyncCSharp.Model;
using ADSyncCSharp.Service;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace ADSyncCSharp.Processor
{
    /**
     * Process a new/change or a deleted entry in Active Directory
     */
    public class ActiveDirectoryProcessor : IEntryProcessor<UserGroup>
    {
        private readonly GroupsApi _groupsApi;
        private readonly RolesApi _rolesApi;
        private readonly UsersApi _usersApi;
        private readonly NpUserService _npUserService;
        private readonly NpGroupService _npGroupService;

        public ActiveDirectoryProcessor(ApiClient apiClient)
        {
            _groupsApi = new GroupsApi(apiClient);
            _rolesApi = new RolesApi(apiClient);
            _usersApi = new UsersApi(apiClient);
            _npUserService = new NpUserService(apiClient);
            _npGroupService = new NpGroupService(apiClient);
        }

        /**
         * Process Active Directory changed entries
         */
        public void ProcessChanged(IList<UserGroup> entry)
        {
            if (entry == null || entry.Count == 0) return;

            ProcessNew(entry);
        }

        /**
         * Process Active Directory deleted entries
         */
        public void ProcessDeleted(IList<UserGroup> entry)
        {
            if (entry == null || entry.Count == 0) return;

            foreach (var element in entry)
            {
                DeleteNPrintingGroup(element);
            }
        }

        /**
         * Process Active Directory new entries
         */
        public void ProcessNew(IList<UserGroup> entry)
        {
            if (entry == null || entry.Count == 0) return;

            foreach (var element in entry)
            {
                var npRoleId = HandleNprintingRole(element.Role);
                if (npRoleId == null) throw new ApiException((int)HttpStatusCode.NotFound, "Missing NPrinting Role: " + element.Role.Name);
                var npGroupId = HandleNprintingGroups(element);
   
                foreach (var user in element.Users)
                {
                    var npUserId = HandleNPrintingUser(user);
                    HandleUserAssociations(npUserId,npGroupId,npRoleId);
                }
            }
        }

        private void DeleteNPrintingGroup(UserGroup group)
        {
            _npGroupService.DeleteNpGroup(group);
        }

        private void HandleUserAssociations(string npUserId, string npGroupId, string npRoleId)
        {
            _npUserService.AddGroupToNprintingUser(npUserId,npGroupId);
            _npUserService.AddRoleToNprintingUser(npUserId,npRoleId);
        }

        private string HandleNprintingRole(Model.Role role)
        {
            RoleListResponse nPrintingRole = _rolesApi.RolesGet(role.Name);
            //Role must exists NPrinting
            if (nPrintingRole.Data.Items != null && nPrintingRole.Data.Items.Count > 0)
            {
                RoleResponseDataItem npRole = nPrintingRole.Data.Items[0];
                return npRole.Id.ToString();
            }
            return null;
        }

        private string HandleNPrintingUser(Model.User user)
        {
            UserListResponse nPrintingUser = _usersApi.UsersGet(user.Email);
            //User already in NPrinting
            if (nPrintingUser.Data.Items != null && nPrintingUser.Data.Items.Count > 0)
            {
                UserResponseDataItem npUser = nPrintingUser.Data.Items[0];
                _npUserService.UpdateNpUser(npUser,user);
                return npUser.Id.ToString();
            }
            else
            {
                return _npUserService.AddNewNpUser(user);
            }
        }

        private string HandleNprintingGroups(UserGroup userGroup)
        {
            GroupResponse nPrintingGroup = _groupsApi.GroupsGet(userGroup.Name);
            //Group already in NPrinting
            if (nPrintingGroup.Data.Items != null && nPrintingGroup.Data.Items.Count > 0)
            {
                GroupResponseDataItem npGroup = nPrintingGroup.Data.Items[0];
                _npGroupService.UpdateNpGroup(npGroup , userGroup);
                return npGroup.Id.ToString();
            }
            else
            {
                return _npGroupService.AddNewNpGroup(userGroup);
            }
        }
    }
}