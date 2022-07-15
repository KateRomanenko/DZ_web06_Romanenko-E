/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

/*Console.Write("Введите элементы через запятую (без пробела): ");
string str = Console.ReadLine();
int[] mass = str.Split(',').Select(int.Parse).ToArray();

/*for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + ", ");
} */

/* int count = 0; 
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
Console.Write("Количество чисел больше нуля: ");
Console.WriteLine(count); */


/*Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.*/

Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

Console.WriteLine(x + " ; " + y);

