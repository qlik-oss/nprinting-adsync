using System;
using System.Net;
using ADSyncCSharp.Model;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace ADSyncCSharp.Service
{
    /**
     * Service to handle operations on NPrinting groups
     */
    public class NpGroupService
    {
        private readonly GroupsApi _groupsApi;
       
        public NpGroupService(ApiClient apiClient)
        {
            _groupsApi = new GroupsApi(apiClient);
        }

        /**
         * Remove an existing NPrinting Group
         */
        public void DeleteNpGroup(UserGroup group)
        {
            GroupResponse nPrintingGroup = _groupsApi.GroupsGet(group.Name);
            //Group already in NPrinting
            if (nPrintingGroup.Data.Items != null && nPrintingGroup.Data.Items.Count > 0)
            {
                GroupResponseDataItem npGroup = nPrintingGroup.Data.Items[0];
                _groupsApi.GroupsIdDelete(npGroup.Id.ToString());
            }
        }

        /**
         * Update an existing NPrinting Group
         */
        public void UpdateNpGroup(GroupResponseDataItem npGroup, UserGroup userGroup)
        {
            //there maybe changes to the Group Details
            _groupsApi.GroupsIdPut(npGroup.Id.ToString(), new GroupUpdateRequest(userGroup.Name, userGroup.Description ?? "", true));
        }

        /**
         * Add a new NPrinting Group
         */
        public string AddNewNpGroup(UserGroup userGroup)
        {
            //Group need to be added in NPRinting
            ApiResponse<Object> postResponse = _groupsApi.GroupsPostWithHttpInfo(new GroupRequest(userGroup.Name, userGroup.Description, true));
            if ((int)HttpStatusCode.Created != postResponse.StatusCode) throw new ApiException(postResponse.StatusCode, "Error creating NPrinting GroupName: " + userGroup.Name);
            var location = postResponse.Headers["Location"];
            var groupId = location.Substring(location.LastIndexOf('/') + 1);
            return groupId;
        }
    }
}
