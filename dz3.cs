int numbs = ReadInt("Введите число N: ");
for (int i = 1; i <= numbs; i++)
{ 
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}