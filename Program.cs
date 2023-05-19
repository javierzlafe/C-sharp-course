
using ConceptsPOO;

Console.WriteLine("Hello, World!");


try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(22, 2, 15));
	Console.WriteLine(new Date(2022, 11, 31));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}