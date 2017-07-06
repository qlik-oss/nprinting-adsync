# Qlik.NPrinting.Rest.Client.Api.RolesApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RolesGet**](RolesApi.md#rolesget) | **GET** /roles | Get the roles.
[**RolesIdGet**](RolesApi.md#rolesidget) | **GET** /roles/{id} | Get a specific role.
[**UsersIdRolesGet**](RolesApi.md#usersidrolesget) | **GET** /users/{id}/roles | Gets the roles for a user.
[**UsersIdRolesPut**](RolesApi.md#usersidrolesput) | **PUT** /users/{id}/roles | Updates the roles for a user.


<a name="rolesget"></a>
# **RolesGet**
> RoleListResponse RolesGet (string rolename = null, bool? enabled = null, string sort = null, int? offset = null, int? limit = null)

Get the roles.

Returns the list of all roles. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class RolesGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new RolesApi(nprintingApiClient);
            var rolename = rolename_example;  // string | The role name to use as a filter. (optional) 
            var enabled = true;  // bool? | Indicates whether to retrieve the active roles (true) or inactive roles (false). (optional) 
            var sort = sort_example;  // string | A comma separated list of fields to use for sorting the entries. Allowed field values are \"name\" and \"description\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.  Usage example: /roles?sort=+name,-description  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Get the roles.
                RoleListResponse result = apiInstance.RolesGet(rolename, enabled, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.RolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rolename** | **string**| The role name to use as a filter. | [optional] 
 **enabled** | **bool?**| Indicates whether to retrieve the active roles (true) or inactive roles (false). | [optional] 
 **sort** | **string**| A comma separated list of fields to use for sorting the entries. Allowed field values are \&quot;name\&quot; and \&quot;description\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /roles?sort&#x3D;+name,-description  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**RoleListResponse**](RoleListResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesidget"></a>
# **RolesIdGet**
> RoleResponseData RolesIdGet (string id)

Get a specific role.

Returns the role specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class RolesIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new RolesApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the role.

            try
            {
                // Get a specific role.
                RoleResponseData result = apiInstance.RolesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.RolesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the role. | 

### Return type

[**RoleResponseData**](RoleResponseData.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidrolesget"></a>
# **UsersIdRolesGet**
> GenericIdListDataResponse UsersIdRolesGet (string id)

Gets the roles for a user.

Returns the ordered list of role IDs for the specified user. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdRolesGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new RolesApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.

            try
            {
                // Gets the roles for a user.
                GenericIdListDataResponse result = apiInstance.UsersIdRolesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.UsersIdRolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user. | 

### Return type

[**GenericIdListDataResponse**](GenericIdListDataResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidrolesput"></a>
# **UsersIdRolesPut**
> void UsersIdRolesPut (string id, List<Guid?> body)

Updates the roles for a user.

Updates the list of role IDs for the specified user. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdRolesPutExample
    {
        public void main()
        {
            
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new RolesApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.
            var body = ;  // List<Guid> | The unordered list of roles for the specified user.

            try
            {
                // Updates the roles for a user.
                apiInstance.UsersIdRolesPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.UsersIdRolesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user. | 
 **body** | **List&lt;Guid&gt;**| The unordered list of roles for the specified user. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

