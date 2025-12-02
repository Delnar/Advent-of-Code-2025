using Day02;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Day 02");

// var FileDataName = "sample.input";
var FileDataName = "data.input";
var FileData = File.ReadAllText(FileDataName);

var pairs = FileData.SplitCSV();

Int64 MySum = 0;

foreach(string s in pairs) {
    var parts = s.SplitDash();
    var first = parts.First();
    var last = parts.Last();

    // If the length of both strings is odd and the same length,
    // There can't be any duplicates
    if ((first.Length % 2 == 1) && first.Length == last.Length) {
        continue;
    }

    Console.WriteLine($" First: {first}, Last: {last}");
    for(Int64 x = first.ToInt64(); x <= last.ToInt64(); x++)
    {
        var str = x.ToString();
        if (str.Length % 2 == 1) continue;  // Odd lengths don't mirror
        (string firstHalf, string SecondHalf) = str.SplitStringInHalf();
        if (firstHalf != SecondHalf) continue;  // Not a duplicate;

        MySum += str.ToInt64();
        Console.WriteLine(str);
    }
}

Console.WriteLine("my sum:" + MySum);

