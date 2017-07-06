using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace ADSyncDemoApp.Component
{
    public class Options
    {
        [Option("u", Required = true,
             HelpText = "Username needs to have sufficient privileges to log in to Active Directory, perform searchesand view deleted objects as well (for the latter requirement see http://support.microsoft.com/kb/892806).")]
        public string BindUser { get; set; }

        [Option("p", Required = true,
             HelpText = "Password of the user to log in to Active Directory")]
        public string BindPassword { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText
            {
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };
            help.AddPreOptionsLine(string.Format("Usage: {0} -u domain/userName -p password",
                Process.GetCurrentProcess().MainModule));
            help.AddOptions(this);
            return help;
        }
    }
}
