﻿Console.Clear();

Console.WriteLine("Primeiro valor: ");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor: ");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine();

float result = v1 + v2;
Console.WriteLine("O resultado da soma é " + result);
Console.WriteLine($"O resultado da soma é {result}");
Console.WriteLine($"O resultado da soma é {v1 + v2}");
Console.WriteLine("O resultado da soma é " + (v1 + v2));
