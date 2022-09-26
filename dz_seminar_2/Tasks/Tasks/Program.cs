int Input(string inputMsg)
{
    Console.WriteLine(inputMsg);
    return Convert.ToInt32(Console.ReadLine());
}

#region Task1
/// <summary>
///  Напишите программу, которая принимает на
///  вход трёхзначное число и на выходе показывает вторую цифру этого числа
/// </summary>
void Task1()
    {

        var inputResult = Input("Введите трехзначное число : ");
        var secondNumber = inputResult / 10 % 10;

        Console.Write($"вторая цифра числа {inputResult} : {secondNumber}");

    }
#endregion

#region Task2
///<summary>
/// Задача 13: Напишите программу, которая с помощью
/// деления выводит третью цифру заданного числа или
/// сообщает, что третьей цифры нет
/// </summary>
 void Task2()
{
    //12341232
    var inputResult = Input("Введите любое число");

    var someCounter = inputResult;

    while (someCounter > 1000)
    {
        someCounter /= 10; // someCounter = someCounter/ 10;
    }
    var result = someCounter % 10;

    Console.WriteLine($"Третья цифра = {result}");
}
#endregion

///<summary>
/// Напишите программу, которая принимает на
///вход цифру, обозначающую день недели, и проверяет,
///является ли этот день выходным.
///</summary>

void Task3()
{
    var inputResult = Input("Введите цифру, обозначающую день недели: ");

    if (inputResult > 7 || inputResult <= 0)
    {
        Console.WriteLine("Неккорректные данные");
        return;
    }
      

    if (inputResult == 6 || inputResult == 7)
        Console.WriteLine("День недели выходной");
    else
        Console.WriteLine("День недели будний");
    

}
//Task1();
//Task2();
//Task3();




// Домашнее задание 3



#region Task19
/// <summary>
///Напишите программу, которая принимает на вход пятизначное число и проверяет,
///является ли оно палиндромом.
/// </summary>


void Task19()
{
    Console.WriteLine("Введите пятизначное целое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int num = n;
    int rev = 0;

    while (n > 0)
    {
        rev = rev * 10 + n % 10;
        n = n / 10;
    }
    if (num == rev)
    {
        Console.WriteLine("Введеное число является полиндромом ");
    }
    else
    {
        Console.WriteLine("Введеное число не является полиндромом ");
    }
}
#endregion

#region Task21_1
/// <summary>
///Напишите программу, которая принимает на вход координаты двух точек и
///находит расстояние между ними в 3D пространстве.
/// </summary>
/// 

void Task21_1()
{
    Console.WriteLine("Введите координаты точки А: ");

    Console.Write("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int az = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Введите координаты точки B: ");

    Console.Write("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int bz = Convert.ToInt32(Console.ReadLine());


    double length = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay)
        + (bz - az) * (bz - az));
    length = Math.Round(length, 2);
    Console.WriteLine($"Расстояние между точками {length}");
}
#endregion

#region Task23
/// <summary>
///Напишите программу, которая принимает на
///вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
/// </summary>
/// 
void Task23()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    Result(num, i);
}

void Result(int num, int i)
{

    if (num > i)
    {
        while (i <= num)
        {
            Console.WriteLine($"Число  {i}  |  Куб числа = {Math.Pow((i), 3)}");
            i++;
        }
    }
    else
    {
        while (i >= num)
        {
            Console.WriteLine($"Число  {num}  |  Куб числа = {Math.Pow((num), 3)}");
            num++;
        }
    }
}




#endregion



//Task19();
//Task21_1();
Task23();

Console.ReadLine();
