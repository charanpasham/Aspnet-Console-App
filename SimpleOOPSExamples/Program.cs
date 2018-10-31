using System;
using System.Collections.Generic;
using System.Linq; 
namespace SimpleOOPSExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collection for student.
            List<Student> studentCollection = new List<Student>{
                new Student("Anderson","Sam",grade.A),
                new Student("xxx","yyy",grade.C),
                new Student("Zelda","Spellmen", grade.A),
                new Student("Hilda","Spellmen", grade.D),
                new Student("Linq", "Ash", grade.A)
            };
            //Collection for worker.
            List<Worker> WorkerCollection = new List<Worker>
            {
                new Worker("Cole", "Han", 1000, 8),
                new Worker("kevin", "Peterson", 2000, 8),
                new Worker("kittens","Bared", 500,6),
                new Worker("Mellisa","Smith",2890,9),
                new Worker("Kender","Jess", 9789,10)
            };
            Console.WriteLine(".................Student Details..............");
            bool firstTime = true;
            //Display students
            foreach (var student in studentCollection.OrderBy(s => s.Grade))
            {
                if (firstTime)
                {
                    Console.WriteLine(nameof(student.FirstName) + " " + nameof(student.LastName) + " " + nameof(student.Grade));
                    firstTime = false;
                }
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }
            Console.WriteLine(".................Worker Details..............");
            firstTime = true;
            //Display workers.
            foreach (var worker in WorkerCollection.OrderBy(w => w.WeekSalary))
            {
                if (firstTime)
                {
                    Console.WriteLine(nameof(worker.FirstName) + " " + nameof(worker.LastName) + " " + nameof(worker.WeekSalary)
                                      + " " + nameof(worker.WorkHoursPerDay) + " " + nameof(worker.MoneyPerHour));
                    firstTime = false;
                }
                Console.WriteLine($"{worker.FirstName}  {worker.LastName}  {worker.WeekSalary} {worker.WorkHoursPerDay}  {worker.MoneyPerHour().ToString("##.##")}");
            }



        }
    }
    public enum grade{
        A,B,C,D,E,F
    }
    //All the classes
    abstract public class Human{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Human(string first, string last){
            FirstName = first;
            LastName = last; 
        }
    }
   public class Student:Human{

        public Student(string first, string last, grade? grade):base(first,last){
            Grade = grade; 
        }
        public grade? Grade { get; set; }
    }
    public class Worker:Human{
        public Worker(string first, string last, decimal WeekSalary, int workHoursPerDay):base(first, last){
            this.WeekSalary = WeekSalary;
            this.WorkHoursPerDay = workHoursPerDay; 
        }
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public const int DaysWorkedPerWeek = 5; 
        public decimal MoneyPerHour(){
            return WeekSalary / (WorkHoursPerDay * DaysWorkedPerWeek); 
        }
    }
}
