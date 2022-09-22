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
Task3();
Console.ReadLine();
