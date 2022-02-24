using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_16_intex
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            //int a = 5, b = 4, c = 0;
            //c = a & b;
            //c = a | b;
            //c = a ^ b;
            //Console.WriteLine(Convert.ToString(c, 2));
            //#endregion
            #region
            int a = 32;
            int b = 12;
            int c = 0;
            int d = 0;
            int e = 0;
            c = a & b;
            d = a ^ b;
            e = a | b;
            string value = Convert.ToString(c, 2);//binary
            string value1 = Convert.ToString(d, 2);//hexa
            string value2 = Convert.ToString(e, 2);//octa
            Console.WriteLine("Output of AND(Binary):{0},value");
            Console.WriteLine("Output of XOR(hexa):{0},value");
            Console.WriteLine("Output of OR(octa):{0},value");
            #endregion


            //string name = "Fariha";
            //Console.WriteLine(name.IndexOf("h"));
            //int i, j;
            //Console.WriteLine("Enter 1st Number \n");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 2nd Number \n");
            //j = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n Before swapping i= {0} and k = {1}", i, j);
            //i = i ^ j;
            //j = i ^ j;
            //i = i ^ j;
            //Console.WriteLine("\n After swapping i= {0} and k = {1}", i, j);
            #region
            //int a = 32, b = 12, c = 0;
            ////c = a & b;
            ////Console.WriteLine("Binary(using &):"+ Convert.ToString(c, 2));
            ////Console.WriteLine("Hexa(using &):" + Convert.ToString(c, 16));
            ////Console.WriteLine("Octal(using &):" + Convert.ToString(c, 8));
            ////c = a | b;
            ////Console.WriteLine("Binary(using |):" + Convert.ToString(c, 2));
            ////Console.WriteLine("Hexa(using |):" + Convert.ToString(c, 16));
            ////Console.WriteLine("Octal(using |):" + Convert.ToString(c, 8));
            ////c = a ^ b;
            ////Console.WriteLine("Binary(using ^):" + Convert.ToString(c, 2));
            ////Console.WriteLine("Hexa(using ^):" + Convert.ToString(c, 16));
            ////Console.WriteLine("Octal(using ^):" + Convert.ToString(c, 8));
            ////c = a << b;
            ////Console.WriteLine("Binary(using <<):" + Convert.ToString(c, 2));
            ////Console.WriteLine("Hexa(using <<):" + Convert.ToString(c, 16));
            ////Console.WriteLine("Octal(using <<):" + Convert.ToString(c, 8));
            //c = a >> b;
            //Console.WriteLine("Binary(using >>):" + Convert.ToString(c, 2));
            //Console.WriteLine("Hexa(using >>):" + Convert.ToString(c, 16));
            //Console.WriteLine("Octal(using >>):" + Convert.ToString(c, 8));
            #endregion



            Console.ReadKey();
        }
    }
}
