﻿using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("==============");

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 12));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}