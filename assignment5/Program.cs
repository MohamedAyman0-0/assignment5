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
            //    #region Q4. Function to Sum Digits of a Number
            // class Program
            //{
            //    static int SumDigits(int number)
            //    {
            //        int sum = 0;
            //        while (number != 0)
            //        {
            //            sum += number % 10;
            //            number /= 10;
            //        }
            //        return sum;
            //    }

            //    static void Main()
            //    {
            //        Console.Write("Enter a number: ");
            //        int num = int.Parse(Console.ReadLine());

            //        Console.WriteLine($"The sum of the digits of the number {num} is: {SumDigits(num)}");
            //    }








            //#endregion
            //    #region Q5. Function IsPrime

            //    class Program
            //{
            //    static bool IsPrime(int number)
            //    {
            //        if (number <= 1) return false;
            //        for (int i = 2; i <= Math.Sqrt(number); i++)
            //        {
            //            if (number % i == 0) return false;
            //        }
            //        return true;
            //    }

            //    static void Main()
            //    {
            //        Console.Write("Enter a number: ");
            //        int num = int.Parse(Console.ReadLine());
            //        Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");
            //    }
            //}

            //#endregion
            //    #region Q6. Function MinMaxArray using Reference Parameters
            //    class Program
            //{
            //    static void MinMaxArray(int[] arr, out int min, out int max)
            //    {
            //        min = arr[0];
            //        max = arr[0];
            //        foreach (int num in arr)
            //        {
            //            if (num < min) min = num;
            //            if (num > max) max = num;
            //        }
            //    }

            //    static void Main()
            //    {
            //        int[] arr = { 3, 7, 2, 9, 1 };
            //        MinMaxArray(arr, out int min, out int max);
            //        Console.WriteLine($"Min = {min}, Max = {max}");
            //    }
            //}
            //#endregion
            //    #region Q7. Iterative Function to Calculate Factorial
            //    class Program
            //{
            //    static long Factorial(int n)
            //    {
            //        long result = 1;
            //        for (int i = 2; i <= n; i++)
            //            result *= i;
            //        return result;
            //    }

            //    static void Main()
            //    {
            //        Console.Write("Enter a number: ");
            //        int num = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
            //    }
            //}
            //#endregion
            #region Q8.ChangeChar Function (Modify character at specific index in a string)
            class Program
        {
            static string ChangeChar(string input, int position, char newChar)
            {
                if (position < 0 || position >= input.Length)
                    return input;

                char[] chars = input.ToCharArray();
                chars[position] = newChar;
                return new string(chars);
            }

            static void Main()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.Write("Enter position to change: ");
                int pos = int.Parse(Console.ReadLine());

                Console.Write("Enter new character: ");
                char c = Console.ReadLine()[0];

                string result = ChangeChar(input, pos, c);
                Console.WriteLine("Modified string: " + result);
            }
        }
        #endregion
    }
    }
}
