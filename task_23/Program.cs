Console.WriteLine("Таблица кубов чисел от 1 до N");
Console.Write("Введите число N: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
int index = 1;
while (index <= n)
{
    int pow = (int) Math.Pow(index, 3);
    Console.Write(pow + " ");
    index++;
}
Console.WriteLine();
