using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

Console.WriteLine("Please input text.");
var inputText = Console.ReadLine();

Console.WriteLine("inputText: " + inputText);

Regex reg1 = new Regex("(?<endChar>[^A-Za-z]) (?<startChar>[A-Za-z])");
for (Match m = reg1.Match(inputText); m.Success; m = m.NextMatch())
{
    inputText = inputText.Replace(m.Value, m.Groups["endChar"] + "" + m.Groups["startChar"]);
}

Regex reg2 = new Regex("(?<endChar>[A-Za-z]) (?<startChar>[^A-Za-z])");
for (Match m = reg2.Match(inputText); m.Success; m = m.NextMatch())
{
    inputText = inputText.Replace(m.Value, m.Groups["endChar"] + "" + m.Groups["startChar"]);
}

Regex reg3 = new Regex("(?<endChar>[^A-Za-z]) (?<startChar>[^A-Za-z])");
for (Match m = reg3.Match(inputText); m.Success; m = m.NextMatch())
{
    inputText = inputText.Replace(m.Value, m.Groups["endChar"] + "" + m.Groups["startChar"]);
}

Console.WriteLine("outputText: " + inputText);