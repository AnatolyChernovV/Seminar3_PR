// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



System.Console.WriteLine("Введите пятизначное число число N: "); // Вывод в консоль
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        System.Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else System.Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else System.Console.WriteLine($"Введи правильное число");

