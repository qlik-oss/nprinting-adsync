# Qlik.NPrinting.Rest.Client.Api.GroupsApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupsGet**](GroupsApi.md#groupsget) | **GET** /groups | Gets the groups.
[**GroupsIdDelete**](GroupsApi.md#groupsiddelete) | **DELETE** /groups/{id} | Deletes a group.
[**GroupsIdGet**](GroupsApi.md#groupsidget) | **GET** /groups/{id} | Get a specific group.
[**GroupsIdPut**](GroupsApi.md#groupsidput) | **PUT** /groups/{id} | Updates a group.
[**GroupsIdUsersGet**](GroupsApi.md#groupsidusersget) | **GET** /groups/{id}/users | Gets the users in a group.
[**GroupsPost**](GroupsApi.md#groupspost) | **POST** /groups | Adds a new group.


<a name="groupsget"></a>
# **GroupsGet**
> GroupResponse GroupsGet (string groupname = null, bool? enabled = null, string sort = null, int? offset = null, int? limit = null)

Gets the groups.

Returns the list of groups. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var groupname = groupname_example;  // string | The group name to use as a filter. (optional) 
            var enabled = true;  // bool? | Indicates whether to retrieve the active groups (true) or inactive groups (false). (optional) 
            var sort = sort_example;  // string | A comma separated list of fields to use for sorting the entries. Allowed field values are \"name\" and \"created\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.  Usage example: /groups?sort=+name,-created  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets the groups.
                GroupResponse result = apiInstance.GroupsGet(groupname, enabled, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupname** | **string**| The group name to use as a filter. | [optional] 
 **enabled** | **bool?**| Indicates whether to retrieve the active groups (true) or inactive groups (false). | [optional] 
 **sort** | **string**| A comma separated list of fields to use for sorting the entries. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /groups?sort&#x3D;+name,-created  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsiddelete"></a>
# **GroupsIdDelete**
> void GroupsIdDelete (string id)

Deletes a group.

Deletes the group specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsIdDeleteExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the group to delete.

            try
            {
                // Deletes a group.
                apiInstance.GroupsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the group to delete. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsidget"></a>
# **GroupsIdGet**
> GroupResponseEntry GroupsIdGet (string id)

Get a specific group.

Returns the group specified by the ID parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the group.

            try
            {
                // Get a specific group.
                GroupResponseEntry result = apiInstance.GroupsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the group. | 

### Return type

[**GroupResponseEntry**](GroupResponseEntry.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsidput"></a>
# **GroupsIdPut**
> void GroupsIdPut (string id, Body2 body)

Updates a group.

Update the group specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsIdPutExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the group to be updated.
            var body = new GroupUpdateRequest(); // Body2 | The group details to update.

            try
            {
                // Updates a group.
                apiInstance.GroupsIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the group to be updated. | 
 **body** | [**GroupUpdateRequest**](GroupUpdateRequest.md)| The group details to update. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsidusersget"></a>
# **GroupsIdUsersGet**
> GenericIdListDataResponse GroupsIdUsersGet (string id, int? offset = null, int? limit = null)

Gets the users in a group.

Returns the list of users for the specified group. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsIdUsersGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the group.
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets the users in a group.
                GenericIdListDataResponse result = apiInstance.GroupsIdUsersGet(id, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsIdUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the group. | 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**GenericIdListDataResponse**](GenericIdListDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupspost"></a>
# **GroupsPost**
> void GroupsPost (Request2 request)

Adds a new group.

Adds a new group, and returns the group object created. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class GroupsPostExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new GroupsApi(nprintingApiClient);
            var request = new GroupRequest(); // GroupRequest | Details about the group to create.

            try
            {
                // Adds a new group.
                apiInstance.GroupsPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GroupRequest**](GroupRequest.md)| Details about the group to create. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

