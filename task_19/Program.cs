Console.WriteLine("Проверка пятизначного числа на палиндром");
Console.Write("Введите положительное целое пятизначное число: ");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
while (number <= 0)
{
    Console.Write("Число должно быть положительным, повторите ввод: ");
    numberString = Console.ReadLine();
    number = int.Parse(numberString!);
}
int lenght = numberString!.Length;
while (lenght != 5)
{
    Console.Write("Число должно быть пятизначным, повторите ввод: ");
    numberString = Console.ReadLine();
    lenght = numberString!.Length;
}
number = int.Parse(numberString!);
int firstDigit = number % 10;
int secondDigit = number / 10 % 10;
int thirdDigit = number / 100 % 10;
int fourthDigit = number / 1000 % 10;
int fifthDigit = number / 10000 % 10;
Console.WriteLine("Является ли число палиндромом?");
if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
