Console.WriteLine("Семинар 1 ДЗ Доп. Задача 3");
Console.WriteLine("Введите рост первого спортсмена:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост второго спортсмена:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост третьего спортсмена:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------");
int first = a;
int second = b;
int third = c;
if (b > a && a > c) 
{ 
    first = b; 
    second = a;
}
if (c > a && a > b) 
{
    first = c; 
    second = a; 
    third = b;
}
if (b > c && c > a) 
{
    first = b; 
    second = c; 
    third = a;
}
if (a > c && c > b) 
{
    first = a; 
    second = c; 
    third = b;
}
if (c > b && b > a) 
{
    first = c; 
    second = b; 
    third = a;
}

Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
