using System.IO;

string COUNTY_DESC = "albany county";
string STREETA = "part 1,";
string STREETB = "  ,  part 2, ,      ";
string CITY = "Albany    ";
string STATE = "NY";
string ZIP = "  12222";
string PHONE = "(518) 555-5555";

List<string?> joinzip = new List<string?>();
List<string?> strings = new List<string?>();

joinzip.Add(CleanString(STATE));
joinzip.Add(CleanString(ZIP));
string state_zip = string.Join(" ", joinzip.Where(s => !string.IsNullOrWhiteSpace(s)));

strings.Add(CleanString(COUNTY_DESC));
strings.Add(CleanString(STREETA));
strings.Add(CleanString(STREETB));
strings.Add(CleanString(CITY));
strings.Add(CleanString(state_zip));
strings.Add(CleanString(PHONE));

string output = string.Join(", ", strings.Where(s => !string.IsNullOrWhiteSpace(s)));


Console.WriteLine(output);
Console.ReadLine();

string? CleanString(string? input)
{
    if (string.IsNullOrWhiteSpace(input)) return null;
    return input.Trim(new char[] { ',', ' ', '\t' });
}