// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напиши ширину"); 
int a = int.Parse(Console.ReadLine()); 
Console.Write("Напиши Высоту: ");
int b = int.Parse(Console.ReadLine()); 

int c = a * b;
int c_2 = (a * 2) + (b * 2);
Console.WriteLine($"Площадь: {c}");


Console.WriteLine($"Периметр: {c_2}");