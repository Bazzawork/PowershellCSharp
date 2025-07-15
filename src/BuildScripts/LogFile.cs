namespace BuildScripts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;


public class TestFile
{
    public string FileName { get; set; }

    /// <summary>
    /// Generates a new file name in the format Verb-yyyyMMdd_HHmmss.ps1
    /// by invoking PowerShell's Get-Verb cmdlet.
    /// </summary>
    public TestFile()
    {
        // (optional) any default init logic
    }


    public string NewFileName()
    {
        // Retrieve all verbs via PowerShell
        List<string> allVerbs;
        using (var ps = PowerShell.Create())
        {
            ps.AddCommand("Get-Verb");
            var results = ps.Invoke();
            allVerbs = results
                .Select(r => r.Members["Verb"].Value?.ToString())
                .Where(v => !string.IsNullOrEmpty(v))
                .ToList();
        }

        if (allVerbs.Count == 0)
            throw new InvalidOperationException("No verbs returned by Get-Verb.");

        // Pick a random verb
        var rnd = new Random();
        string verb = allVerbs[rnd.Next(allVerbs.Count)];

        // Format timestamp
        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

        return $"{verb}-{timestamp}.ps1";
    }
}