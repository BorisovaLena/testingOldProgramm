using System;

namespace Борисова_ПР3_вар_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название дисциплины");
            string nazvanie = Console.ReadLine();
            Exam A = new Exam(nazvanie);
            A.nazv();
            Console.WriteLine("Введите количество пятерок: ");
            A.five = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество четверок: ");
            A.four = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество троек: ");
            A.three = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество двоек: ");
            A.two = Convert.ToInt32(Console.ReadLine());
            A.info();
            Console.WriteLine("Введите название предмета");
            string predm = Console.ReadLine();
            ContrWork B = new ContrWork(predm);
            B.nazv();
            B.info();
            Console.WriteLine("Введите вашу первую оценку за контрольную работу: ");
            B.first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу вторую оценку за контрольную работу: ");
            B.second = Convert.ToInt32(Console.ReadLine());
            B.yourBall();

        }
    }
}
