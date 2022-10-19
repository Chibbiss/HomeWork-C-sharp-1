// Homework task 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Вариант 1:

Console.Write("Input a first number: ");
int n1 =Convert.ToInt32( Console.ReadLine());
Console.Write("Input a second number: ");
int n2 =Convert.ToInt32( Console.ReadLine());
if (n1 > n2)
{
Console.WriteLine($" {n1} is  max and {n2} is min");
}
else
{
Console.WriteLine($" {n2} is max and  {n1} is min");
}
Console.WriteLine();
*/

// Вариант 2:
/*
int MaxDigit(int val1, int val2)
{
    int max;

   
        if (val1 > val2)
        max = val1 ;
        else
        max = val2;
        return max;
        
        
}
Console.Write ("Введите первое число: ");
int n1 =Convert.ToInt32( Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 =Convert.ToInt32( Console.ReadLine());
Console.WriteLine($" Максимальное число : {MaxDigit(n1,n2)}");
*/

// Homework task 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input a first number :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number :");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a third number :");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.WriteLine($"Максимальное число будет : {max}");
*/

// Вариант 2:
/*
int MaxDigit(int val1, int val2, int val3)
{
    int max = val1;

    if (val2 > max) max = val2;
    if (val3 > max) max = val3;
    return max;

}
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Максимальное число : {MaxDigit(n1, n2, n3)}");



// Homework task 3
//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());

bool func(int n)
{
    if (n % 2 == 0)
        return true;
    else
        return false;
}
Console.Write($"Является ли число чётным : {func(n)}");



// Homework task 4
//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
 int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
           int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
  */         