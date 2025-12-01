using Day01;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(50.rotate("L20"));

int startingValue = 50;
// string[] lines = File.ReadAllLines("sample.input");
string[] lines = File.ReadAllLines("data-01.input");

int hitZero = 0;

foreach (var line in lines) {
	// startingValue = startingValue.rotate(line);

	var data = startingValue.rotate43(line);
	startingValue = data.retValue;
	hitZero += data.zeroPasses;
	Console.WriteLine($"Current Value: {startingValue}");
}

Console.WriteLine($"Hit Zero Count: {hitZero}");