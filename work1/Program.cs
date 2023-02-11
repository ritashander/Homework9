// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

System.Console.WriteLine(PrintNumbers(1,5));

string PrintNumbers(int start, int end)
{
     if(start == end)
    {
         return start.ToString();
    }
    return(start + " " + PrintNumbers(start + 1, end));
}
