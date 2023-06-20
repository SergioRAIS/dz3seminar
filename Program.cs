Console.WriteLine("Введите число: ");
string numbar = Console.ReadLine() ?? "";
int len = numbar.Length;

if (len == 5)
{
    if (numbar[0] == numbar[4] && numbar[1] == numbar[3])
    {
        Console.WriteLine($"{numbar} - ДА!");
    }
    else
    {
        Console.WriteLine($"{numbar} - нет!");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {numbar} - не пятизначное");
}