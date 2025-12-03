using Day02;

namespace Day02;
public class Part02
{
	public void Run()
	{
		// var FileDataName = "sample.input";
		var FileDataName = "data.input";
		var FileData = File.ReadAllText(FileDataName);

		var pairs = FileData.SplitCSV();

		Int64 MySum = 0;

		foreach(string s in pairs) {
			var parts = s.SplitDash();
			var first = parts.First();
			var last = parts.Last();

			Console.WriteLine($" First: {first}, Last: {last}");
			for(Int64 x = first.ToInt64(); x <= last.ToInt64(); x++)
			{
				var str = x.ToString();
				var factors = str.Length.GetFactors();
				foreach(var factor in factors) {
					if (factor == 0) { continue;}
					if (factor == str.Length) { continue;} // Full string match is trivial
					if (str.SplitIntoChunks(factor).Distinct().Count() == 1)
					{
						MySum += x;
						Console.WriteLine($"{str}");
						break;
					}					
				}
			}
		}

		Console.WriteLine("my sum:" + MySum);
		
	}
}