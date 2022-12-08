Console.WriteLine("put the amount of strings");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("put the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArray(array);
Print(array);
FindByPosition(array);
FindByValue(array);


void FindByValue(int[,] arr)
{
    Console.WriteLine("put a value of finding number");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == num)
            {
                Console.WriteLine($"the position of number is {i},{j} ");
                return;
            }
        }
    }
    Console.WriteLine("there is no number like that");
}

void FindByPosition(int[,] arr)
{ 
    Console.WriteLine("the number of string");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("the number of column");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x <= arr.GetLength(0) && y <= arr.GetLength(1) && x >= 0 && y >= 0)
        {
            Console.WriteLine(arr[x,y]);
        }
        else 
        {
            Console.WriteLine("there is no elements like that");
        }
}


int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 101);
        }
    }
    return arr;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}