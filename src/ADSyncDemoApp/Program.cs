using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using ADSyncCSharp.Processor;
using ADSyncCSharp.Service;
using ADSyncDemoApp.Component;
using CommandLine;
using Qlik.NPrinting.Rest.Client.Client;

namespace ADSyncDemoApp
{
    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
               //get required args from command line
               var options = new Options();
               if (!Parser.Default.ParseArguments(args, options))
               {
                   Console.WriteLine("Use --help for help with the command line arguments.");
                   throw new ArgumentException("Some arguments could not be parsed.");
               }

               //Get the highest committedUSN for an Incremental or Full sync
               IRepositoryService repoService = new FileRepositoryService(@"AdSyncHighestCommittedUSN.txt");
               
               //Load configuration parameters
               NameValueCollection configValues = ConfigurationManager.AppSettings;
               AdSyncConfig dca = AdSyncConfig.FromConfig(configValues, options);
              
               //Create NPrinting Rest Client
               ApiClient npclient = NPrintingApiFactory.GetNPrintingApiClient(dca.GetNpUrl());

               //Run the sync operation
               ActiveDirectorySyncService syncService = new ActiveDirectorySyncService(dca, new ActiveDirectoryProcessor(npclient));
               AdSync adSync = new AdSync(repoService,syncService);

               adSync.Sync();
            }
            catch (ApiException e)
            {
              Console.WriteLine("API Error: " + e);
            }
            catch (IOException e)
            {
              Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
