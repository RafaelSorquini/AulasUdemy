using CursoUdemy.Entidades;
using CursoUdemy.Entidades.Enuns;
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
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.Write("Enter amount for Withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Account account = new Account(number, holder, balance, limit);

                account.Withdraw(balance, limit, withdraw);



                Console.WriteLine("New balance: " + account.Balance);
            }

            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }




            //try
            //{
            //    Console.Write("Room number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    reservation.UpdateDates(checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Error in format: " + e.Message);
            //}
            //catch (DomainException e)
            //{
            //    Console.WriteLine("Error in reservation: " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Unexpected error: " + e.Message);
            //}







            //BusinessAccount account = new BusinessAccount(8019, "Bob Brown", 100.00, 50);

            //Console.WriteLine(account.Balance);

            //Comment c1 = new Comment("Have a nice trip!");

            //Comment c2 = new Comment("Wow that's awesome!");

            //Post p1 = new Post(
            //    DateTime.Parse("21/06/2018 13:05:44"),
            //    "Traveling to New Zeland",
            //    "I'm going to visit this wonderful country!",
            //    12
            //    );

            //p1.AddComment(c1);
            //p1.AddComment(c2);



            //Comment c3 = new Comment("Have a nice trip!");

            //Comment c4 = new Comment("Wow that's awesome!");

            //Post p2 = new Post(
            //    DateTime.Parse("21/06/2018 13:05:44"),
            //    "Traveling to New Zeland",
            //    "I'm going to visit this wonderful country!",
            //    12
            //    );

            //p1.AddComment(c3);
            //p1.AddComment(c4);



            //Console.WriteLine(p1);
            //Console.WriteLine(p2);


            //Console.Write("Enter departament's name: ");
            //string deptName = Console.ReadLine();
            //Console.WriteLine("Enter worker data");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            //Console.Write("Base salary: ");
            //double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Departament dept = new Departament(deptName);
            //Worker worker = new Worker(name, level, baseSalary, dept);

            //Console.Write("How many contracts to this worker?: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} contract data: ");
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    Console.Write("Duration (hours):");
            //    int hours = int.Parse(Console.ReadLine());

            //    HourContract contract = new HourContract(date, valuePerHour, hours );

            //    worker.AddContract(contract);
            //}

            //Console.WriteLine();

            //Console.Write("Entre com mes e ano: ");
            //string mesano = Console.ReadLine();
            //int mes = int.Parse(mesano.Substring(0, 2));
            //int ano = int.Parse(mesano.Substring(3));

            //Console.WriteLine("Name: " + worker.Name);
            //Console.WriteLine("Department: " + worker.Departament.Name);
            //Console.WriteLine("Income for " + mesano + ": " + worker.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture);

            //Order order = new Order
            //{
            //    Id = 1080,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            //};

            //Console.WriteLine(order);

            //string txt = OrderStatus.PendingPayment.ToString();


            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            //Console.WriteLine(os);

            // mais um teste de commit

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Teste");
            //}

            //TimeSpan t1 = new TimeSpan(1, 30, 10);

            //TimeSpan mult = t1.Multiply(2.0);

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
    }
}