//Console.WriteLine("Hello, World!");

using FizzBuzzClassLibrary;

var fizzBuzzService = new FizzBuzzService();

fizzBuzzService.GetInput(100);

Console.WriteLine($"X: {fizzBuzzService.X}, Y: {fizzBuzzService.Y}, N: {fizzBuzzService.N}");

Console.ReadLine();
