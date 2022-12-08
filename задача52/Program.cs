Console.WriteLine("put the amount of strings");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("put the number of columns");
int number2 = Convert.ToInt32(Console.ReadLine());
int[,] arrayTable = new int[ number1, number2 ];
var random = new Random();
var result = 0;

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
for (int j = 0; j < arrayTable.GetLength(1); j++)
{
arrayTable[i,j] = random.Next(10);
Console.Write($"{arrayTable[i,j]} ");
result += arrayTable[i,j];
}
Console.WriteLine($"   average is {result}");
result = 0;
Console.WriteLine();
}
