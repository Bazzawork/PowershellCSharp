namespace RandomSentence;
using System.Management.Automation;
using LoremNET;

[Cmdlet(VerbsCommon.Get, $"{Consts.ModulePrefix}Sentence")]
public class GetCEPackerSentenceCmdlet : PSCmdlet
{
    [Parameter()]
    public SwitchParameter Short { get; set; }

    protected override void EndProcessing()
    {
        string sentence = Lorem.Sentence(Short ? 5 : 10);
        WriteObject(sentence);
    }
}
