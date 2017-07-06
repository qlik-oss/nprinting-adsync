# Qlik.NPrinting.Rest.Client.Api.AppsApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppsGet**](AppsApi.md#appsget) | **GET** /apps | Generates the list of Qlik NPrinting Apps.
[**AppsIdGet**](AppsApi.md#appsidget) | **GET** /apps/{id} | Returns details about a specific app.


<a name="appsget"></a>
# **AppsGet**
> AppListResponse AppsGet (string sort = null, int? offset = null, int? limit = null)

Generates the list of Qlik NPrinting Apps.

This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the `sort` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class AppsGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new AppsApi(nprintingApiClient);
            var sort = sort_example;  // string | A comma separated list of fields to use for sorting the apps. Allowed field values are \"name\" and \"created\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.  Usage example: /apps?sort=+name,-created  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Generates the list of Qlik NPrinting Apps.
                AppListResponse result = apiInstance.AppsGet(sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**AppListResponse**](AppListResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsidget"></a>
# **AppsIdGet**
> AppResponse AppsIdGet (Guid id)

Returns details about a specific app.

This endpoint returns detailed information about the app specified by the `id` parameter. The calling user must be authorized to view the specified app. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class AppsIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new AppsApi(nprintingApiClient);
            var id = id_example;  // Guid? | The ID of the app.

            try
            {
                // Returns details about a specific app.
                AppResponse result = apiInstance.AppsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid**| The ID of the app. | 

### Return type

[**AppResponse**](AppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

