using System.Management.Automation;
using System.Net.Http;

namespace PSCoreNetscaler
{
    [Cmdlet(VerbsCommon.New,"NSCredential")]
    public class NewNSCredentialCommand : PSCmdlet
    {
        [Parameter]
        public PSCredential Credentials { get; set; }

        [Parameter]
        public string IPAddress { get; set; }
        protected override void ProcessRecord()
        {
            WriteObject("This is a test");
        }
    }
}