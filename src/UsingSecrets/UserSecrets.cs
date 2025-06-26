namespace UsingSecrets;

using System.Management.Automation;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

[Cmdlet(VerbsCommon.Get, $"{Consts.ModulePrefix}Secret")]
public class GetBazSecretCmdlet : PSCmdlet
{
    protected override void ProcessRecord()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<GetBazSecretCmdlet>()
            .AddEnvironmentVariables()
            .Build();
        WriteObject(configuration["TestSecret"] ?? "No secret found");
    }
}