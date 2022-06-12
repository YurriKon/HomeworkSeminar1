
Console.WriteLine("Семинар 1 ДЗ Доп. Задача 4");
Console.WriteLine("Введите число секунд:");
int a = Convert.ToInt32(Console.ReadLine());
int m = a/60;
int H = m/60;
int M = m%60;
int S = a%60;
Console.WriteLine(H + ":" + M + ":" + S);
