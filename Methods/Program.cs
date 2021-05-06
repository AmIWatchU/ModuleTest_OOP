using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        //Розробити методи для знаходження мінімального, максимального та середнього
        //значень, а також суми елементів одновимірного числового масиву.Продемонструвати
        //роботу цих методів.

        //Метод для знаходження для знаходження мінімального значення
        static void Min(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Мiнiмальне значення масиву: ");
            Console.WriteLine(arr[0]);
        }
        //Метод для знаходження для знаходження максимального значення
        static void Max(int[] arr)
        {
            Array.Sort(arr);
            var last = arr[arr.Length - 1];
            Console.WriteLine("Максимальне значення масиву: ");
            Console.WriteLine(last);
        }
        //Метод для знаходження для знаходження середнього значення
        static void Avr(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            Console.WriteLine("Середнє значення масиву: ");
            Console.WriteLine("{0:0.##}", sum / arr.Length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Масив: ");
            int[] a = new[] { 2, 4, 6, 8, 22, 84, 64, 45, -24 };
            foreach (var b in a)
            {
                Console.Write(b + " ");
            }
            Console.Write("\n");
            Min(a);
            Max(a);
            Avr(a);
            Console.ReadKey();
        }

    }
}
