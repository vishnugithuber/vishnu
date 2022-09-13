
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Library1;

namespace HandsonSep12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = @"E:\NET\HandsonSep12\Library1\bin\Debug\Library1.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.FullName);
                MemberInfo[] min = item.GetMembers();
                foreach (var item1 in min)
                {
                    Console.WriteLine(item1.Name);
                }
                MethodInfo[] max = item.GetMethods();
                foreach (var item2 in max)
                {
                    Console.WriteLine(item2.Name);

                    ParameterInfo[] pinfo = item2.GetParameters();
                    foreach (var p in pinfo)
                    {
                        Console.WriteLine("parameter name: " + p.Name);
                        Console.WriteLine("parameter position: " + p.Position);
                        Console.WriteLine("parameter type: " + p.ParameterType);
                    }
                }
                t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);



                double cube = (double)item.InvokeMember("Cube1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 400.0d });
                Console.WriteLine("cube of the number is" + " " + cube);
                double sqrt = (double)item.InvokeMember("squareroot of the number is", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 200.0d });
                Console.WriteLine("Squareroot of the number is" + " " + sqrt);
                break;
            }
            Console.ReadLine();


        }
    }
    }
