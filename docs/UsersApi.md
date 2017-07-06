# Qlik.NPrinting.Rest.Client.Api.UsersApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersGet**](UsersApi.md#usersget) | **GET** /users | Gets the user list.
[**UsersIdDelete**](UsersApi.md#usersiddelete) | **DELETE** /users/{id} | Delete a user.
[**UsersIdFiltersGet**](UsersApi.md#usersidfiltersget) | **GET** /users/{id}/filters | Gets the filters for a user.
[**UsersIdFiltersPut**](UsersApi.md#usersidfiltersput) | **PUT** /users/{id}/filters | Update the filters for a user.
[**UsersIdGet**](UsersApi.md#usersidget) | **GET** /users/{id} | Gets a specified user.
[**UsersIdGroupsGet**](UsersApi.md#usersidgroupsget) | **GET** /users/{id}/groups | Gets a list of groups.
[**UsersIdGroupsPut**](UsersApi.md#usersidgroupsput) | **PUT** /users/{id}/groups | Updates a user&#39;s list of groups.
[**UsersIdPut**](UsersApi.md#usersidput) | **PUT** /users/{id} | Update an existing user.
[**UsersIdRolesGet**](UsersApi.md#usersidrolesget) | **GET** /users/{id}/roles | Gets the roles for a user.
[**UsersIdRolesPut**](UsersApi.md#usersidrolesput) | **PUT** /users/{id}/roles | Updates the roles for a user.
[**UsersPost**](UsersApi.md#userspost) | **POST** /users | Adds a user.


<a name="usersget"></a>
# **UsersGet**
> UserListResponse UsersGet (string email = null, string username = null, bool? enabled = null, string sort = null, int? offset = null, int? limit = null)

Gets the user list.

Returns the list of users. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var email = email_example;  // string | The email of the user to be used as a filter. (optional) 
            var username = username_example;  // string | The username to use as a filter. (optional) 
            var enabled = true;  // bool? | Indicates whether to retrieve the active users (true) or inactive users (false). (optional) 
            var sort = sort_example;  // string | A comma separated list of fields to be used for sorting the users. Allowed field values are \"name\" and \"created\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.     Usage example: /users?sort=+name,-created  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets the user list.
                UserListResponse result = apiInstance.UsersGet(email, username, enabled, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email of the user to be used as a filter. | [optional] 
 **username** | **string**| The username to use as a filter. | [optional] 
 **enabled** | **bool?**| Indicates whether to retrieve the active users (true) or inactive users (false). | [optional] 
 **sort** | **string**| A comma separated list of fields to be used for sorting the users. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.     Usage example: /users?sort&#x3D;+name,-created  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**UserListResponse**](UserListResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersiddelete"></a>
# **UsersIdDelete**
> void UsersIdDelete (string id)

Delete a user.

Delete the user specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdDeleteExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user to delete.

            try
            {
                // Delete a user.
                apiInstance.UsersIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user to delete. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidfiltersget"></a>
# **UsersIdFiltersGet**
> List<Guid?> UsersIdFiltersGet (string id)

Gets the filters for a user.

Returns the ordered list of filter IDs for the specified user. Note that the filter sequence, in general, is not commutative, so the order will affect the result. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdFiltersGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.

            try
            {
                // Gets the filters for a user.
                GenericIdListDataResponse result = apiInstance.UsersIdFiltersGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdFiltersGet: " + e.Message );
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

<a name="usersidfiltersput"></a>
# **UsersIdFiltersPut**
> void UsersIdFiltersPut (string id, List<Guid> body)

Update the filters for a user.

Updates the ordered list of filter IDs for the specified user. Note that the filter sequence, in general, is not commutative, so the order will affect the result. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdFiltersPutExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user
            var body = ;  // List<Guid> | The ordered list of the filters for the specified user.

            try
            {
                // Update the filters for a user.
                apiInstance.UsersIdFiltersPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdFiltersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user | 
 **body** | **List&lt;Guid?&gt;**| The ordered list of the filters for the specified user. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidget"></a>
# **UsersIdGet**
> UserResponseEntry UsersIdGet (string id)

Gets a specified user.

Returns the user specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user to return.

            try
            {
                // Gets a specified user.
                UserResponseEntry result = apiInstance.UsersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user to return. | 

### Return type

[**UserResponseEntry**](UserResponseEntry.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidgroupsget"></a>
# **UsersIdGroupsGet**
> List<Guid?> UsersIdGroupsGet (string id, int? offset = null, int? limit = null)

Gets a list of groups.

Returns the list of groups for the user specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdGroupsGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user to return groups for.
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets a list of groups.
                GenericIdListDataResponse result = apiInstance.UsersIdGroupsGet(id, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdGroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user to return groups for. | 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**GenericIdListDataResponse**](GenericIdListDataResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidgroupsput"></a>
# **UsersIdGroupsPut**
> void UsersIdGroupsPut (string id, List<Guid> body)

Updates a user's list of groups.

Updates the unordered list of group IDs for the specified user. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdGroupsPutExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.
            var body = ;  // List<Guid> | The unordered list of groups for the specified user.

            try
            {
                // Updates a user's list of groups.
                apiInstance.UsersIdGroupsPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdGroupsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user. | 
 **body** | **List&lt;Guid&gt;**| The unordered list of groups for the specified user. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidput"></a>
# **UsersIdPut**
> void UsersIdPut (string id, Body1 body)

Update an existing user.

Update the user specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersIdPutExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user object to update.
            var body = new UserUpdateRequest(); // UserUpdateRequest | The user details to update.

            try
            {
                // Update an existing user.
                apiInstance.UsersIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the user object to update. | 
 **body** | [**UserUpdateRequest**](UserUpdateRequest.md)| The user details to update. | 

### Return type

void (empty response body)

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
            AdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.

            try
            {
                // Gets the roles for a user.
                GenericIdListDataResponse result = apiInstance.UsersIdRolesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdRolesGet: " + e.Message );
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
            AdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the user.
            var body = ;  // List<Guid> | The unordered list of roles for the specified user.

            try
            {
                // Updates the roles for a user.
                apiInstance.UsersIdRolesPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdRolesPut: " + e.Message );
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

<a name="userspost"></a>
# **UsersPost**
> void UsersPost (UserRequest userRequest)

Adds a user.

Adds a new user, and returns its ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class UsersPostExample
    {
        public void main()
        {
            
            AdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new UsersApi(nprintingApiClient);
            var userRequest = new UserRequest(); // UserRequest | The details about the user to add.

            try
            {
                // Adds a user.
                apiInstance.UsersPost(userRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userRequest** | [**UserRequest**](UserRequest.md)| The details about the user to add. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

