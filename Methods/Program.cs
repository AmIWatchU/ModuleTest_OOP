using System;

namespace Methods
{
    class Program
    {
        //Розробити методи для знаходження мінімального, максимального та середнього
        //значень, а також суми елементів одновимірного числового масиву.Продемонструвати
        //роботу цих методів.

        //Метод для знаходження  мінімального значення
        static void Min(int[] arr)
        {
            var min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min) min = arr[i];

            Console.WriteLine("Мiнiмальне значення масиву: ");
            Console.WriteLine(min);
        }
        //Метод для знаходження максимального значення
        static void Max(int[] arr)
        {
            var max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max) max = arr[i];
            Console.WriteLine("Максимальне значення масиву: ");
            Console.WriteLine(max);
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
            int[] a = new[] {2, 4, 6, 8, 22, 84, 64, 45, -24 };
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
