// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


System.Console.WriteLine(sum(1, 3));


    int sum(int n, int m) 
{
    if(n == m)
    {
        return m;
    }
    return n + sum(n + 1, m);
}
