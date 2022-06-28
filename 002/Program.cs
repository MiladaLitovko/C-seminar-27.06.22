//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rand = new Random();
//int number = rand.Next(100, 1000);
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
//Console.WriteLine(number);
Zadacha11(number);


void Zadacha11(string number)
{
    Console.Write(number[0]);
    Console.Write(number[2]);
    Console.WriteLine();
}