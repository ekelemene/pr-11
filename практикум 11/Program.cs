using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace практикум_11
{
    internal class Program
    {
        //static void SayHello() => Console.WriteLine("Привет"); //Задание 1

        //static void SayBye() => Console.WriteLine("Пока");

        //static double Sum(double a, double b) //Задание 2
        //{
        //    return a + b;
        //}
        //static double Sub(double a, double b)
        //{
        //    return a - b;
        //}
        //static double Mul(double a, double b)
        //{
        //    return a * b;
        //}
        //static double Div(double a, double b)
        //{
        //    return a / b;
        //}
        
        //static double Func(double x) //Задание 3
        //{
        //    if (x < 5)
        //    {
        //        return (4 * Math.Pow(x, 2) + 1);
        //    }
        //    else
        //    {
        //        return 3 * Math.Pow(x, 2) - 2;
        //    }
        //}

        //static double Func1(double x)            //Задание 3. 2 способ
        //{
        //    return Math.Pow(x, 2) + 1;
        //}
        //static double Func2(double x)            
        //{
        //    return 3 * x - 2;
        //}

        static void Main(string[] args)
        {
            //задание 1.Вывод  сообщений приветствия и прощания с использованием дополнительных методов.
            //SayHello();
            //SayBye();

            //Задача 2. Нахождение суммы, разности, произведения и частного двух целых чисел с использованием дополнительных методов.
            //Console.Write("Введите 1 число = ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите 2 чимло = ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Сумма: {Sum(num1, num2)}");
            //Console.WriteLine($"Разность: {Sub(num1, num2)}");
            //Console.WriteLine($"Произведение: {Mul(num1, num2)}");
            //Console.WriteLine($"Произведение: {Div(num1, num2):f2}");

            //Задание 3.Вычисление значения функции
            //Console.WriteLine("Введите x = ");
            //double x = double.Parse(Console.ReadLine());
            //double y = Func(x);
            //Console.WriteLine($"Значение функции y при x = {x} равно {y}");

            //Задание 3.Вычисление значения функции. 2 способ
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //double y = x < 5 ? Func1(x) : Func2(x);
            //Console.WriteLine($"y = {y}");



        }
    }
}