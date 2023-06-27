string[,] table = new string[2, 5];
// String.Empty
// tadble[0,0]  tadble[0,1] tadble[0,2] tadble[0,3] tadble[0,4]
// tadble[1,0]  tadble[1,1] tadble[1,2] tadble[1,3] tadble[1,4]


/*table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"{table[rows, columns]}");
    }
}*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);// [1;10)
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);