/*
// Найти кубы чисел от 1 до N

Console.WriteLine("Программа находит куб чисел от 1 до N");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int kub = 1;

for (int i = 1; i <= N; i++)
{
    kub = i * i * i;
    Console.WriteLine("Куб числа " +  i  + " равен "  +  kub);
}
*/


/*
// Подсчитать сумму цифр в числе

Console.WriteLine("Программа подсчитывает сумму цифр числа");
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int Sum = 0;

while(N != 0)
{
    Sum = Sum + (N % 10);
    N = N / 10;
}
Console.WriteLine("Идет вычеслительный процесс ...");
Console.WriteLine("Сумма цифр равна: " + Sum);
*/

// Написать программу вычисления произведения чисел от 1 до N

/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int product = 1;

for (int i = 1; i <= N; i++)
{
    product = i * product;
    Console.WriteLine("Произведение числа " + i + " равно " + product);
}
*/

// Показать кубы чисел, заканчивающихся на четную цифру
/*
Console.WriteLine("Программа находит куб чисел от 1 до N заканчивающихся на четную цифру");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int kub = 1;

for (int i = 1; i <= N; i++)
{
    kub = i * i * i;
    if(kub % 2 == 0)
    {
        Console.WriteLine("Куб числа " +  i  + " равен "  +  kub);
    }
}
*/