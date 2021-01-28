using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(), new Worker(), new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(), new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }
    interface IWorker
    {
        void Work();
        
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("eatmanager");
        }

        public void GetSalary()
        {
            Console.WriteLine("getsalarymanager");
        }

        public void Work()
        {
            Console.WriteLine("workmanager");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("eatworker");
        }

        public void GetSalary()
        {
            Console.WriteLine("getsalaryworker");
        }

        public void Work()
        {
            Console.WriteLine("workworker");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("workrobot");
        }
    }
}
