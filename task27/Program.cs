Console.Clear(); 

Console.WriteLine("Введите число: ");
String StringNumber=Console.ReadLine(); 

int sum = 0;         
Char[]CharNumber = StringNumber.ToCharArray(); 
for (int i = 0; i < StringNumber.Length; i++)
{
    sum += Convert.ToInt32(StringNumber[i]-'0');               
}
Console.WriteLine("Сумма цифр в этом числе равна " + sum);
          