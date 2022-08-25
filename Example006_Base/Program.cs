// Div
int numberA = new Random().Next(1, 20);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 20);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 20);
Console.WriteLine(numberC);
int numberD = new Random().Next(1, 20);
Console.WriteLine(numberD);
int numberE = new Random().Next(1, 20);
Console.WriteLine(numberE);

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
if (numberD > max) max = numberD;
if (numberE > max) max = numberE;

Console.Write("Max = ");
Console.WriteLine(max);