using Day02;

namespace Day02;
public class Part01
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

			

		}

		Console.WriteLine("my sum:" + MySum);
		
	}

}