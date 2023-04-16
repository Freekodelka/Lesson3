/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

int readInput()
{
    Console.Write("Введите n: ");
    return int.Parse(Console.ReadLine());
}

void outputResult(int n)
{
    Console.WriteLine("---------------------------");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"| {i, 10} | {Math.Pow(i,3), -10} |");
    }
    Console.WriteLine("---------------------------");
}
outputResult(readInput());

