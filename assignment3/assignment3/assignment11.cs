using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment11
    {
        static void Main(string[] args)
        {
            double m1 = 100;
            Console.WriteLine("Meter   :    Kilometer");
            double k1 = ConvertDistance.cmtk(m1);
            Console.WriteLine("{0}     :    {1}", m1, k1);
            double m2 = 250;
            double k2 = ConvertDistance.cmtk(m2);
            Console.WriteLine("{0}   :    {1}", m2, k2);
            double k3 = 34.9;
            Console.WriteLine();
            Console.WriteLine("Kilometer     :    Meter");
            double m3 = ConvertDistance.cktm(k3);
            Console.WriteLine("{0}           :    {1}", k3, m3);
            double k4 = 4.345;
            double m4 = ConvertDistance.cktm(k4);
            Console.WriteLine("{0}         :  {1}", k4, m4);
            Console.Read();
        }
        public static class ConvertDistance
        {
            public static double cmtk(double meters)
            {
                return meters / 1000;
            }

            public static double cktm(double kilometers)
            {
                return kilometers * 1000;
            }
        }
    }
}
