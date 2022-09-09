﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public delegate Dept numb(Dept p);
        public delegate void numb1(List<Employee> m);
        public delegate List<Employee> numb2(int i, List<Employee> p);
        public class Dept
        {
            public int DeptNo
            {
                get;
                set;
            }
            public string DeptName
            {
                get;
                set;
            }
            public string Location
            {
                get;
                set;
            }
            public List<Employee> prod
            {
                get;
                set;
            }

            List<Employee> p = new List<Employee>();
            public Dept Adding(Dept t)
            {


                if (p.Count <= 10)
                {
                    Employee m = new Employee();
                    Console.WriteLine("enter the employee no");
                    m.EmployeeNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the name");
                    m.Empname = Console.ReadLine();
                    Console.WriteLine("Enter the dept no");
                    m.Deptno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the salary");
                    m.Salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the manager");
                    m.Manager = Console.ReadLine();



                    p.Add(m);
                    t.prod = p;
                    return t;
                }
                else
                {

                    Console.WriteLine("You can't add more than 10 in a dept");
                    return t;

                }
            }


        }
        public class Employee
        {

            public int EmployeeNo
            {
                get;
                set;
            }
            public string Empname
            {
                get;
                set;
            }
            public int Deptno
            {
                get;
                set;
            }
            public int Salary
            {
                get;
                set;

            }
            public string Manager
            {
                get;
                set;
            }
            public List<Employee> Edit(int EmpId, List<Employee> m)
            {
                Console.WriteLine("Which part you want to modify?\n 1.Empname\n  2.Salary\n 3.Manager");
                int w = Convert.ToInt32(Console.ReadLine());
                switch (w)
                {
                    case 1:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter the new name which is to modify");
                                item.Empname = Console.ReadLine();

                            }
                        }

                        break;

                    case 2:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter the salary which is to modify");
                                item.Salary = Convert.ToInt32(Console.ReadLine());

                            }
                        }

                        break;
                    case 3:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter the new manager which is to modify");
                                item.Manager = Console.ReadLine();


                            }
                        }

                        break;
                    default:
                        break;
                }

                return m;
            }
            public List<Employee> Delete(int id, List<Employee> m)
            {
                m = m.Where(m1 => m1.EmployeeNo != id).ToList();
                return m;

            }
            public void Displaybymgr(List<Employee> m)
            {
                Console.WriteLine("Enter the name of the manager whom name of employees you want to see ");
                string s = Console.ReadLine();
                var ti = m.Where(mi => mi.Manager == s).ToList();
                if (ti.Count > 0)
                {
                    foreach (var item in ti)
                        Console.WriteLine(item.Empname);
                }
                else
                {
                    Console.WriteLine("No employees is working under him");
                }
            }
            public void Display(List<Employee> m)
            {
                foreach (var item in m)
                {
                    Console.WriteLine($"{item.EmployeeNo} {item.Empname} {item.Deptno} {item.Salary} {item.Manager}\n");
                }

            }

        }
    }
}
