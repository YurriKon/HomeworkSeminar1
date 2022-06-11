Console.WriteLine("Семинар 1 ДЗ Доп. Задача 1");
Console.WriteLine("Введите число больше нуля:");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
if (a > 0)
{
    while (b < (a+1))
    {
        Console.WriteLine(1);
        b++;
    }    
}
else
{
    Console.WriteLine("Введено некорректное число");
}
