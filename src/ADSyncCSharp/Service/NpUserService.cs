using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace ADSyncCSharp.Service
{
    /**
     * Service to handle NPrinting user operations 
     */
    public class NpUserService
    {
        private readonly UsersApi _usersApi;
  
        public NpUserService(ApiClient apiClient)
        {
            _usersApi = new UsersApi(apiClient);
        }

        /**
         * Add a role to NPrinting user
         */
        public void AddRoleToNprintingUser(string npUserId, string npRoleId)
        {
            //Get existing roles assigned to the user
            var npUserRolesList = _usersApi.UsersIdRolesGet(npUserId);
            List<Guid> userRoles = npUserRolesList.Data.Items.Select(Guid.Parse).ToList();
            userRoles.Add(Guid.Parse(npRoleId));
            _usersApi.UsersIdRolesPut(npUserId, userRoles);
        }

        /**
         * Add a group to NPrinting user
         */
        public void AddGroupToNprintingUser(string npUserId, string npGroupId)
        {
            //Get existing groups assigned to the user
            var npUserGroupsList = _usersApi.UsersIdGroupsGet(npUserId);
            List<Guid> userGroups = npUserGroupsList.Data.Items.Select(Guid.Parse).ToList();
            userGroups.Add(Guid.Parse(npGroupId));
            _usersApi.UsersIdGroupsPut(npUserId, userGroups);
        }

        /**
         * Update an existing NPrinting user
         */
        public void UpdateNpUser(UserResponseDataItem npUser, Model.User adUser)
        {
            var userId = npUser.Id.ToString();

            //There may be changes to the user details in Active Directory 
            UserUpdateRequest userUpdReq = new UserUpdateRequest(
                adUser.Email,
                Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                true,
                adUser.Username,
                adUser.Domainaccount ?? "",
                npUser.Timezone,
                npUser.Locale,
                npUser.Folder ?? "",
                npUser.Subfolder ?? "");
            //Update the user details in case of any changes
            _usersApi.UsersIdPut(userId, userUpdReq);
        }

        /**
         * Create a new NPrinting user
         */
        public string AddNewNpUser(Model.User adUser)
        {
            //user needs to be added in NPRinting
            ApiResponse<Object> postResponse = _usersApi.UsersPostWithHttpInfo(new UserRequest(
                adUser.Email,
                Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                true,
                adUser.Username,
                adUser.Domainaccount,
                "Europe/Berlin",
                UserLocale.En,
                "",
                ""
            ));
            if ((int)HttpStatusCode.Created != postResponse.StatusCode) throw new ApiException(postResponse.StatusCode, "Error creating NPrinting User: " + adUser.Username);
            var location = postResponse.Headers["Location"];
            var userId = location.Substring(location.LastIndexOf('/') + 1);
            return userId;
        }
    }
}
