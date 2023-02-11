Console.Clear(); 

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;

for (int i = 1; i < b; i++)
{
    res = res * a;
}

Console.WriteLine(res);