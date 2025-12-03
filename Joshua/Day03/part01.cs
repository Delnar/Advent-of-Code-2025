using Day03;

namespace Day03;
public class Part01
{
	public void Run()
	{
		// var FileDataName = "sample.input";
		var FileDataName = "data.input";
		var FileData = File.ReadAllLines(FileDataName);

		var FirstValue = 0;
		var SecondValue = 0;
		var FinalValue = 0;
		int index = 0;
		int arrayLength = 0;

		foreach(var line in FileData) {
			var digits = line.GetDigitList();
			Console.WriteLine(string.Join(",", digits));
			FirstValue = 0;
			SecondValue = 0;
			index = 0;
			arrayLength = digits.Count();

			foreach(var digit in digits) {
				index++;
				if (digit == null) { continue; }
				if (FirstValue < digit.Value && index < arrayLength) {
					FirstValue = digit.Value;
					SecondValue = 0;
					continue;
				}
				if (SecondValue < digit.Value) {
					SecondValue = digit.Value;
					continue;
				}
			}
			var newNumber = (FirstValue * 10) + SecondValue;
			Console.WriteLine($"newNumber = {newNumber}");
			FinalValue += newNumber;
			
		}		
		Console.WriteLine("Final Value: " + FinalValue);
	}

}