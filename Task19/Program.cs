/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/
string number;

void readInput()
{
    Console.WriteLine("Enter number: ");
    number = Console.ReadLine();
}

void outputResult(bool result)
{
    if (result)
    {
        Console.WriteLine("Число - палиндром");  
    }
    else
    {
        Console.WriteLine("Число - не является палиндромом");
    }
}

bool isPalindrom(string index)
{
    if (index[0] == index[4] && index[1] == index[3])
        return true;
    return false;
}

readInput();
outputResult(isPalindrom(number));

 

