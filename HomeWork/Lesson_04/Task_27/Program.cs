//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


System.Console.Write("Введите целое число: ");
int number = System.Convert.ToInt32(System.Console.ReadLine());

int Sum(int number)
{

    int count = System.Convert.ToString(number).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        temp = number - number % 10;
        result = result + (number - temp);
        number = number / 10;
    }
    return result;
}

int sum = Sum(number);
System.Console.WriteLine("Сумма цифр в числе " + number + " = " + sum);
