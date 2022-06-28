/*9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.*/

Random rand = new Random();
int number = rand.Next(10, 100);
Zadacha9(number);


void Zadacha9(int currentNumber)
{
    Console.WriteLine(currentNumber);
    int digitFirst = currentNumber/10;
    int digitSecond = currentNumber%10;
    
    if(digitFirst > digitSecond)
    {
        Console.WriteLine(digitFirst);
        }
    else if(digitFirst < digitSecond)
    {
        Console.WriteLine(digitSecond);
        }
    else
    {
        Console.WriteLine("цифры числа равны");
    }
}