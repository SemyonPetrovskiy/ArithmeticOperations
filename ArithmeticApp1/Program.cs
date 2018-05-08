using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // бинарные операции ------------------------------------------

            int x = 10;
            int z = x + 5; // 15
            Console.WriteLine(z);

            int z1 = x - 5; // 5
            int y = x * 5; // 50
            Console.WriteLine(z1);
            Console.WriteLine(y);

            double x1 = 10;
            double z2 = x1 / 4; // 2.5
            Console.WriteLine(z2);

            double z3 = 10 / 4; // 2
            Console.WriteLine(z3);

            double z4 = 10.0 / 4; // 2.5
            Console.WriteLine(z4);

            double z5 = x % 4; // Остаток от деления 2
            Console.WriteLine(z5);

            // унарные операции -------------------------------------------------

            int a = 4;
            a++; // a = 5 операция инкремента увеличивает значение a на единицу 
            Console.WriteLine(a);

            int a1 = 4;
            int b = ++a1; // a1 = 5 b = 5 префиксный инкремент увеличивает а1 на единицу и присваевает переменной b
            Console.WriteLine($"a1={a1} b={b}");

            int a2 = 4;
            int b1 = a2++; // a2 = 5 b1 = 4 постфиксный инкремент присваевает переменной b1 значение a2 
                           // а потом увеличивает a1 на единицу
            Console.WriteLine($"a2={a2} b1={b1}");

            int a3 = 4;
            int b2 = --a3; // a3 = 3 b2 = 3 префиксный декремент уменьшает а3 на единицу и присваевает переменной b2 
            Console.WriteLine($"a3={a3} b2={b2}");

            int a4 = 4;
            int b3 = a4--; // a4 = 3 b3 = 4 постфиксный декремент присваевает переменной b3 значение a4 
                           // а потом уменьшает a4 на единицу
            Console.WriteLine($"a4={a4} b3={b3}");

            // Порядок операций
            // 1 Инкремент и декремент
            // 2 Умножение и деление
            // 3 Сложение и вычетание

            int m = 3;
            int n = 5;
            int k = 40;
            int l = k-- - n * m;
            // (k--) = 40 | k = 39
            // n * m = 15
            // 40-15 = 25
            Console.WriteLine($"m={m} n={n} k={k} l={l}");

            int m1 = 3;
            int n1 = 5;
            int k1 = 40;
            int l1 = (k1 - (--n1)) * m1;
            Console.WriteLine($"m1={m1} n1={n1} k1={k1} l1={l1}");

            Console.ReadKey();
        }
    }
}
