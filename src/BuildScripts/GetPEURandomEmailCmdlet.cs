namespace BuildScripts;
using System.Management.Automation;
using LoremNET;

[Cmdlet(VerbsCommon.Get, $"{Consts.ModulePrefix}Email")]
public class GetPEURandomEmailCmdlet : PSCmdlet
{
    [Parameter()]
    public SwitchParameter UsernameOnly { get; set; }

    protected override void EndProcessing()
    {
        string email = Lorem.Email();
        WriteObject(UsernameOnly == true ? email.Split('@')[0] : email);
    }
}
