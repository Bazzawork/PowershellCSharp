namespace RandomSentence;

using System.Management.Automation;

using LoremNET;

[Cmdlet(VerbsCommon.Get, $"{Consts.ModulePrefix}Sentence")]
public class GetCEPackerSentenceCmdlet : PSCmdlet
{
    [Parameter(Position = 0, Mandatory = false)]
    public int Min { get; set; } = 10;
    [Parameter(Position = 1, Mandatory = false)]
    public int Max { get; set; } = 15;
    [Parameter(Position = 2, Mandatory = false, ValueFromPipeline = true)]
    public string? Name { get; set; } = null;

    protected override void EndProcessing()
    {
        if (!string.IsNullOrWhiteSpace(Name))
        {
            for (int i = 0; i < 3; i++)
            {
                WriteObject(System.Text.RegularExpressions.Regex.Replace(
                    Lorem.Sentence(Min, Max),
                    @"\.$",
                    $", {Name}"
                ));
            }
        }
        else
        {
            WriteObject(Lorem.Sentence(Min, Max));
        }
    }
}
