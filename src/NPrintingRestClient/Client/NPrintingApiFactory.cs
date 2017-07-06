using System.Collections.Generic;
using System.Linq;
using System.Net;
using Qlik.NPrinting.Rest.Client.Api;
using RestSharp;

namespace Qlik.NPrinting.Rest.Client.Client
{
    /**
     * Create and instance of a concrete NPrinting client with Ntlm Authenticator
     */
    public class NPrintingApiFactory
    {
        public static ApiClient GetNPrintingApiClient(string npUrl)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            ApiClient apiClient = new ApiClient(npUrl);

            AuthenticationApi auth = new AuthenticationApi(apiClient);
            
            IList<RestResponseCookie> cookies = auth.GetNPrintingCookiesWithHttpInfo();
            var xsrfToken = cookies.SingleOrDefault(cookie => cookie.Name.Equals("NPWEBCONSOLE_XSRF-TOKEN"));
            if (xsrfToken != null)
            {
              apiClient.DefaultHeader.Add("X-XSRF-TOKEN", xsrfToken.Value);
            }

            apiClient.RestClient.Authenticator = new NtlmAuthenticator();
            auth.NtlmAuthentication();
            
            return apiClient;
        }
    }
}
