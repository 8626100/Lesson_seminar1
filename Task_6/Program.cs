//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("ведите число N");
int N=Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
{
    Console.WriteLine($"Да, число {N} - четное"); 
} 
else
{
     Console.WriteLine($"Нет, число {N} - нечетное"); 
}
