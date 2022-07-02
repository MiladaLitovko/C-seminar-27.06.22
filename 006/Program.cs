/*Задача 21: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.*/

Console.WriteLine("Введите координаты числа A");
int numberAX = Convert.ToInt32(Console.ReadLine());
int numberAY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа B");
int numberBX = Convert.ToInt32(Console.ReadLine());
int numberBY = Convert.ToInt32(Console.ReadLine());
double Length = 0;
Length = Math.Sqrt(Math.Pow(numberAX-numberBX,2)+Math.Pow(numberAY-numberBY,2));
Console.WriteLine(Length);
