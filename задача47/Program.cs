Console.WriteLine("Введите количество строк");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int number2 = Convert.ToInt32(Console.ReadLine());
double[,] arrayTable = new double[number1, number2];
var random = new Random();
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i, j] = new Random().Next(-10,10) / 1.25 ;
        Console.Write($"{arrayTable[i, j]}; ");
    }
    Console.WriteLine();
}


