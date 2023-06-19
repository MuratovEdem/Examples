
// Методы
// Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();

// Вид2
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2(msg: "Текст", count: 4);

// Вид3

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид4

string Method4(int count, string text)
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

/*string Method4(int count, string text)
{
    int i =0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);*/

for (int i = 1; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
