/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Net;
using NUnit.Framework;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Qlik.NPrinting.Rest.Client.Test.Api
{
    
    /// <summary>
    ///  Class for testing FiltersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    class FiltersApiTests : BaseNPrintingClinetTest
    {
        private FiltersApi _instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            _instance = new FiltersApi(NprintingApiClient);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
       
        }

        /// <summary>
        /// Test an instance of FiltersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<FiltersApi>(_instance, "response is FiltersApi");
        }

        
        /// <summary>
        /// Test FiltersGet
        /// </summary>
        [Test(Description = "Get the list of Filters assigned to the user.")]
        public void FiltersGetTest()
        {
            var response = _instance.FiltersGetWithHttpInfo();
            Assert.IsInstanceOf<ApiResponse<FilterListResponse>> (response, "response is FilterListResponse");
            Assert.That(response.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }
        
       
        /// <summary>
        /// Test FiltersIdGet
        /// </summary>
        [Test]
        public void FiltersIdGetTest()
        {
            //Assume there is a filter assigned to the user
            var id = _instance.FiltersGet().Data.Items[0].Id.ToString();
            var response = _instance.FiltersIdGetWithHttpInfo(id);
            Assert.IsInstanceOf<ApiResponse<FilterResponse>> (response, "response is FilterResponse");
            Assert.That(response.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
            Assert.That(response.Data.Data.Id.ToString(), Is.EqualTo(id));
        }
        
        /// <summary>
        /// Test FiltersIdPut
        /// </summary>
        [Test]
        public void FiltersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Body body = null;
            //instance.FiltersIdPut(id, body);
            
        }
        
        /// <summary>
        /// Test FiltersPost
        /// </summary>
        [Test]
        public void FiltersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FilterRequest filterRequest = null;
            //instance.FiltersPost(filterRequest);
            
        }
        
    }
}
