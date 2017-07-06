# Qlik.NPrinting.Rest.Client.Api.FiltersApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FiltersGet**](FiltersApi.md#filtersget) | **GET** /filters | Gets the list of filters.
[**FiltersIdDelete**](FiltersApi.md#filtersiddelete) | **DELETE** /filters/{id} | Deletes a filter.
[**FiltersIdGet**](FiltersApi.md#filtersidget) | **GET** /filters/{id} | Gets details of the specified filter.
[**FiltersIdPut**](FiltersApi.md#filtersidput) | **PUT** /filters/{id} | Updates an existing filter.
[**FiltersPost**](FiltersApi.md#filterspost) | **POST** /filters | Creates a new filter.


<a name="filtersget"></a>
# **FiltersGet**
> FilterListResponse FiltersGet (string appId = null, bool? enabled = null, string sort = null, int? offset = null, int? limit = null)

Gets the list of filters.

Returns the list of filters that are visible to the user.  The response includes the title and other details about each filter. The list can be filtered by a particular app, and is sorted in the order specified by the `sort` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class FiltersGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new FiltersApi(nprintingApiClient);
            var appId = appId_example;  // string | The ID of the app to filter on. (optional) 
            var enabled = true;  // bool? | Indicates whether to retrieve the active filters (true) or inactive filters (false). (optional) 
            var sort = sort_example;  // string | A comma separated list of fields used for sorting the filters. Allowed field values are \"name\" and \"created\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.  Usage example: /filters?sort=+name,-created  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets the list of filters.
                FilterListResponse result = apiInstance.FiltersGet(appId, enabled, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The ID of the app to filter on. | [optional] 
 **enabled** | **bool?**| Indicates whether to retrieve the active filters (true) or inactive filters (false). | [optional] 
 **sort** | **string**| A comma separated list of fields used for sorting the filters. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /filters?sort&#x3D;+name,-created  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**FilterListResponse**](FilterListResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtersiddelete"></a>
# **FiltersIdDelete**
> void FiltersIdDelete (string id)

Deletes a filter.

Deletes the filter specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class FiltersIdDeleteExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new FiltersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the filter to delete.

            try
            {
                // Deletes a filter.
                apiInstance.FiltersIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the filter to delete. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtersidget"></a>
# **FiltersIdGet**
> InlineResponse2007 FiltersIdGet (string id)

Gets details of the specified filter.

Returns the details of the filter specified by the `id` parameter.  

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class FiltersIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new FiltersApi(nprintingApiClient);
            var id = id_example;  // string | The ID of the filter.

            try
            {
                // Gets details of the specified filter.
                FilterResponse result = apiInstance.FiltersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the filter. | 

### Return type

[**FilterResponse**](FilterResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtersidput"></a>
# **FiltersIdPut**
> void FiltersIdPut (string id, Body body)

Updates an existing filter.

Updates the filter specified by the `id` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class FiltersIdPutExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new FiltersApi(nprintingApiClient);
            var id = id_example;  // string | ID of the filter to update.
            var body = new Body(); // Body | The filter details to update.

            try
            {
                // Updates an existing filter.
                apiInstance.FiltersIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the filter to update. | 
 **body** | [**FilterRequest**](FilterRequest.md)| The filter details to update. | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterspost"></a>
# **FiltersPost**
> void FiltersPost (FilterRequest filterRequest)

Creates a new filter.

Creates a new filter, and returns its ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class FiltersPostExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new FiltersApi(nprintingApiClient);
            var filterRequest = new FilterRequest(); // FilterRequest | the filter request

            try
            {
                // Creates a new filter.
                apiInstance.FiltersPost(filterRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterRequest** | [**FilterRequest**](FilterRequest.md)| the filter request | 

### Return type

void (empty response body)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

