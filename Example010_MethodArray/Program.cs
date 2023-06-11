int[] array = { 14, 32, 53, 47, 56, 65, 73, 28 };

int n = array.Length;
int find = 47;

int index = 0;

while (index < n)
{
    if(array[index] == find);
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index = index + 1;
}