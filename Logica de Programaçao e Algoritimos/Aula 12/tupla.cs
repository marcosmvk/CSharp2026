//Tupla
using static System.Console;

var clodoaldo = (34, 34, "Heitor", "SENAI", 'B');

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item2}");
System.Console.WriteLine($"Nome do filho do clodo: {clodoaldo.Item3}");
clodoaldo.Item1 = 54;
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");


