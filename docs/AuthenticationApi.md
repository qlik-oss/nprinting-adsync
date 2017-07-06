# Qlik.NPrinting.Rest.Client.Api.AuthenticationApi

All URIs are relative to *https://localhost:4993/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NtlmAuthentication**](AuthenticationApi.md#ntlmAuthentication) | **GET** /login/ntlm | Authenticates the caller using NTLM authentication.
[**LoginPost**](AuthenticationApi.md#loginpost) | **POST** /login | Authenticates the caller using Basic authentication.


<a name="loginntlmget"></a>
# **NtlmAuthentication**
> void NtlmAuthentication ()

Authenticates the caller using NTLM authentication.

Call this endpoint to authenticate the user. For cross-site (CORS) requests, set `withCredentials` to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  ```javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr = new XMLHttpRequest(); xhr.open('GET', 'http://example.com:port/api/v1/login/ntlm', true); xhr.withCredentials = true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: 'http://example.com:port/api/v1/login/ntlm',    xhrFields: {       withCredentials: true    } });  ``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class LoginNtlmGetExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new AuthenticationApi();

            try
            {
                //Get all the cookies needed to Authenticate the user
                IList<RestResponseCookie> cookies = auth.GetNPrintingCookiesWithHttpInfo();
                // Authenticates the caller using NTLM authentication.
                apiInstance.NtlmAuthentication();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LoginNtlmGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does need to have the `X-XSRF-TOKEN`.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginpost"></a>
# **LoginPost**
> AuthenticationResponse LoginPost (Request request)

Authenticates the caller using Basic authentication.

Call this endpoint to authenticate the user 

### Example
```csharp
using System;
using System.Diagnostics;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Example
{
    public class LoginPostExample
    {
        public void main()
        {
            IAdSyncConfig adSyncconf = new AdSyncConfigTest();
            var nprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(adSyncconf);
            var apiInstance = new AuthenticationApi(nprintingApiClient);
            var request = new AuthenticationRequest(); // Request | Details about the user to authenticate.

            try
            {
                //Get NPrinting Cookies for Authentication.
                IList<RestResponseCookie> cookies = auth.GetNPrintingCookiesWithHttpInfo();
                //Cookies need to be added to the request for Authentication
                ...
                // Authenticates the caller using Basic authentication.
                AuthenticationResponse result = apiInstance.LoginPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationRequest** | [**AuthenticationRequest**](AuthenticationRequest.md)| Details about the user to authenticate. | 

### Return type

[**AuthenticationResponse**](AuthenticationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

