using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Q1. Difference Between Passing Value Type by Value vs. by Reference
            //static void ChangeValue(int x)
            //{
            //    x = 100;
            //}

            //static void ChangeValueByRef(ref int x)
            //{
            //    x = 100;
            //}

            //static void Main()
            //{
            //    int a = 5;
            //    ChangeValue(a);
            //    Console.WriteLine("After by value: " + a);  // Output: 5

            //    ChangeValueByRef(ref a);
            //    Console.WriteLine("After by reference: " + a);  // Output: 100
            //}
            //#endregion } 
            //#region Q2.Difference Between Passing Reference Type by Value vs. by Reference


            //class MyClass
            //        {
            //            public int Value = 10;
            //        }

            //        class Progra
            //        {
            //            static void ModifyByValue(MyClass obj)
            //            {
            //                obj.Value = 20; // changes original object's data
            //                obj = new MyClass(); // new reference (won’t affect original)
            //                obj.Value = 999;
            //            }

            //            static void ModifyByRef(ref MyClass obj)
            //            {
            //                obj = new MyClass(); // new reference (affects original)
            //                obj.Value = 999;
            //            }

            //            static void Main()
            //            {
            //                MyClass a = new MyClass();

            //                ModifyByValue(a);
            //                Console.WriteLine("After ModifyByValue: " + a.Value); // Output: 20

            //                ModifyByRef(ref a);
            //                Console.WriteLine("After ModifyByRef: " + a.Value);   // Output: 999
            //            }




            //        #endregion
            //    #region Q3.Function to Accept 4 Parameters and Return Sum and Subtraction



            //    class Program
            //{
            //    static void SumAndSubtract(int a, int b, out int sum, out int diff)
            //    {
            //        sum = a + b;
            //        diff = a - b;
            //    }

            //    static void Main()
            //    {
            //        Console.Write("Enter first number: ");
            //        int a = int.Parse(Console.ReadLine());

            //        Console.Write("Enter second number: ");
            //        int b = int.Parse(Console.ReadLine());

            //        int sum, diff;
            //        SumAndSubtract(a, b, out sum, out diff);

            //        Console.WriteLine("Sum = " + sum);
            //        Console.WriteLine("Difference = " + diff);
            //    }
            //}


            //#endregion
            #region Q4. Function to Sum Digits of a Number
         class Program
        {
            static int SumDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            static void Main()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine($"The sum of the digits of the number {num} is: {SumDigits(num)}");
            }
        







        #endregion
        #region Q5.
        #endregion
        #region Q6.
        #endregion
        #region Q7.
        #endregion
        #region Q8.
        #endregion
    }
    }
}
