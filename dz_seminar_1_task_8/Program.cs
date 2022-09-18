// Задача 8: Напишите программу, которая на вход принимает число (N > 0), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число , которое больше 0 : ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 1;
while(a <= num)
{
if(a % 2 ==0)
{
    Console.Write(a + "  ");    
    a = a + 1;
}
else 
{
    a = a + 1;    
}
 }
 Console.WriteLine();