namespace BuildScripts;

using System.Management.Automation;
using TenableApi;

[Cmdlet(VerbsCommon.Get, "CeTenableAgentGroup")]
public class CeTenableAgentGroupCmdlet : PSCmdlet
{
    protected override void EndProcessing() {
        // string Content = "TestContent";
        string Content = new TenableApi.GetAgentGroups().GetGroupsAsync().Result.Content;
        WriteObject(Content);
    }
}
