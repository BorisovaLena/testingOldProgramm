using System;
using System.Collections.Generic;
using System.Text;

namespace Борисова_ПР3_вар_1._7
{
    abstract class Mod
    {
        public abstract void nazv();//вывод названия
        public abstract double ball();//подсчет среднего балла
        public abstract void info();//вывод среднего балла
    }
    class Exam: Mod
    {
        public string nazvanie;//название дисциплины
        public int five;//количество пятерок за экзамен
        public int four;//количество четверок за экзамен
        public int three;//количество троек за экзамен
        public int two;//количество двоек за экзамен
        public double kol;//количество студентов, сдавших экзамен
        public Exam(string nazvanie)
        {
            this.nazvanie = nazvanie;
        }
        public override void nazv()//выводи название дисциплины, по которому был экзамен
        {
            Console.WriteLine("Вы сдаете экзамен по дисциплине "+nazvanie);
        }
        public override double ball()//подсчет среднего балла
        {
            kol = (5 * five + 4 * four + 3 * three + 2 * two) / (five + four + three + two);
            return kol;
        }
        public override void info()//вывод среднего балла
        {
            Console.WriteLine("Средний балл группы: "+ kol);
            
        }
    }
    class ContrWork: Exam
    {
        public string predm;//название предмета
        public int first;//первая оценка студента за контрольную работу
        public int second;//вторая оценка студента за контрольную работу
        public double itball;//итоговая оценка студента за контрольную работу
        public ContrWork(string predm):base(predm)
        {
            this.predm = predm;
        }
        public override void nazv()//выводи название дисциплины, по которому была контрольная работа
        {
            Console.WriteLine("Вы пишете контрольную работу по " + predm);
        }
        new public void info()//вывод количества студентов, которые написали контрольную работу
        {
            base.info();
            Console.WriteLine("Написали контрольную работу "+ kolich() + " студентов");
        }
        public double kolich()//подсчет количесва студентов, которые написали контрольную работу
        {
            return five + four + three + two;
        }
        public void yourBall()// вывод итоговой оценки за контрольную работу
        {
            itball = (first + second)/2;
            Console.WriteLine("Ваш балл: "+itball);
        }
    }
}
