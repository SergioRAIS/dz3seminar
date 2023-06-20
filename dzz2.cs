
int x1 = ReadInt("Введите координату 1 модуля A: ");
int y1 = ReadInt("Введите координату 2 модуля A: ");
int z1 = ReadInt("Введите координату 3 модуля A: ");
int x2 = ReadInt("Введите координату 1 модуля B: ");
int y2 = ReadInt("Введите координату 2 модуля B: ");
int z2 = ReadInt("Введите координату 3 модуля B: ");
int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;
double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"расстояние отрезка {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}