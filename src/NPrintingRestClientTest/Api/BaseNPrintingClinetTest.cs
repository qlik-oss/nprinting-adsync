using System;
using ADSyncCSharp.Model;
using ADSyncCSharp.Service;
using NUnit.Framework;
using Qlik.NPrinting.Rest.Client.Client;

namespace Qlik.NPrinting.Rest.Client.Test.Api
{
    class BaseNPrintingClinetTest
    {
        protected ApiClient NprintingApiClient;

        [SetUp]
        public void SetUp()
        {
            NprintingApiClient = NPrintingApiFactory.GetNPrintingApiClient(@"https://localhost:4993");
        }
    }
}