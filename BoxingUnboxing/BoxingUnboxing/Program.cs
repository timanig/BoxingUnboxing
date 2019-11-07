using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var var0 = 3;
            //int val1 = 4;
            //float val2 = val1;
            //int val3 = (int)val2;

            //Console.WriteLine(val2);

            //double result;
            //string str = "abc";
            //Double.TryParse(str, out result);

            //Console.WriteLine(result);

            int x = 25;
            object o =x; //boxing using implicit conversion
           
            if (o is int val)
            {
                Console.WriteLine(val);
            }



            //var array = new int[] { 10,11,12};

            //Console.WriteLine(array[0]);


            //var list = new List<int>();
            //list.Add(10);
            //list.Add(11);
            //list.Add(12);
            //Console.WriteLine(list);



            var carList = new Car();
            carList[1] = "Porsche";
            carList[2] = "Lamborghini";
            Console.WriteLine(carList[41]);




        }
    }
}
