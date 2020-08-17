using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace CursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
 // mais um teste de commit

            TimeSpan t1 = new TimeSpan(1, 30, 10);

            TimeSpan mult = t1.Multiply(2.0);

            //int n = int.Parse(Console.ReadLine());


            //int[,] mat = new int[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]); 
            //    }
            //}

            //Console.WriteLine("Main Diagonal:");

            //for (int i = 0; i < n ; i++)
            //{
            //    Console.WriteLine(mat[i, i] + " ");
            //}
            //Console.WriteLine();

            //int count = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(mat[i,j] < 0)
            //        count++;
            //    }
            //}

            //Console.WriteLine("Negative numbers: " + count);

            //List<Funcionario> list = new List<Funcionario>();

            //Console.WriteLine("How many employees will be registered? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Employee #" + i + ":");
            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    list.Add(new Funcionario(id, name, salary));

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the employee id that have salary increase : ");
            //int increase = int.Parse(Console.ReadLine());

            //Funcionario emp = list.Find(x => x.Id == increase);

            //if(emp != null)
            //{
            //    Console.WriteLine("Enter the percentage : ");
            //    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    emp.IncreaseSalary(percentage);
            //}

            //else
            //{
            //    Console.WriteLine("This id not exist!");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Update list of employees:");


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            
            //List<Funcionario> list = new List<Funcionario>();

            //Console.WriteLine("How many employees will be registered? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Employee #" + i + ":");
            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    list.Add(new Funcionario(id, name, salary));

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the employee id that have salary increase : ");
            //int increase = int.Parse(Console.ReadLine());

            //Funcionario emp = list.Find(x => x.Id == increase);

            //if(emp != null)
            //{
            //    Console.WriteLine("Enter the percentage : ");
            //    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    emp.IncreaseSalary(percentage);
            //}

            //else
            //{
            //    Console.WriteLine("This id not exist!");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Update list of employees:");


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////list.Add("Maria");
            ////list.Add("Alex");
            ////list.Add("Bob");
            ////list.Add("Anna");

            ////list.Insert(2, "Marco");

            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////Console.WriteLine("List count: " + list.Count);


            ////string s1 = list.Find(x => x[0] == 'A');
            ////Console.WriteLine("Primeiro com A: " + s1);


            ////string s2 = list.FindLast(x => x[0] == 'A');
            ////Console.WriteLine("Ultimo com A: " + s2);



            ////List<string> list2 = list.FindAll(x => x.Length == 5);
            ////Console.WriteLine("-----------------------------");

            ////foreach (var item in list2)
            ////{
            ////    Console.WriteLine(item);
            ////}




        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}