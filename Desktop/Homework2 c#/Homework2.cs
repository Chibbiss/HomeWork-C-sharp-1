// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Write("Input a 3digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number / 10 % 10 ;

// Console.WriteLine ($"Second digit of {number} is {result}");



// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
*/
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Сonsole.Write ("Введите день недель : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6)

    Console.WriteLine ("Будний день");
else 
if
 (number == 6)
    Console.WriteLine ("Суббота");
else 
if
  (number == 7)
    Console.WriteLine ("Воскресенье");
    else 
Console.WriteLine ("Не является днем недели");
*/
