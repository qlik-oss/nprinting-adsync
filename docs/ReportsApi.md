# Qlik.NPrinting.Rest.Client.Api.ReportsApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsGet**](ReportsApi.md#reportsget) | **GET** /reports | Gets the list of reports.
[**ReportsReportIdGet**](ReportsApi.md#reportsreportidget) | **GET** /reports/{reportId} | Gets details about a specific report.


<a name="reportsget"></a>
# **ReportsGet**
> ReportListResponse ReportsGet (string appId = null, string sort = null, int? offset = null, int? limit = null)

Gets the list of reports.

Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the `sort` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class ReportsGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new ReportsApi(nprintingApiClient);
            var appId = appId_example;  // string | The ID of the app to filter on. (optional) 
            var sort = sort_example;  // string | A comma separated list of fields to be used for sorting the reports. Allowed field values are \"title\" and \"created\". Fields can be prefixed by \"+\" and \"-\" to indicate, respectively, ascending and descending order.  Usage example: /reports?sort=+title,-created  (optional) 
            var offset = 56;  // int? | The number of entries to skip. Default is 0. (optional)  (default to 0)
            var limit = 56;  // int? | The maximum number of entries to return. Default is 50. (optional)  (default to 50)

            try
            {
                // Gets the list of reports.
                ReportListResponse result = apiInstance.ReportsGet(appId, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The ID of the app to filter on. | [optional] 
 **sort** | **string**| A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  | [optional] 
 **offset** | **int?**| The number of entries to skip. Default is 0. | [optional] [default to 0]
 **limit** | **int?**| The maximum number of entries to return. Default is 50. | [optional] [default to 50]

### Return type

[**ReportListResponse**](ReportListResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsreportidget"></a>
# **ReportsReportIdGet**
> InlineResponse2005 ReportsReportIdGet (string reportId)

Gets details about a specific report.

Returns the details about the specified report specified by the `reportId` parameter. 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class ReportsReportIdGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new ReportsApi(nprintingApiClient);
            var reportId = reportId_example;  // string | The report ID.

            try
            {
                // Gets details about a specific report.
                ReportResponse result = apiInstance.ReportsReportIdGet(reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsReportIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportId** | **string**| The report ID. | 

### Return type

[**ReportResponse**](ReportResponse.md)

### Authorization

Authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

