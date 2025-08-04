using System;
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
            //#endregion
            #region Q2.Difference Between Passing Reference Type by Value vs. by Reference


class MyClass
        {
            public int Value = 10;
        }

        class Progra
        {
            static void ModifyByValue(MyClass obj)
            {
                obj.Value = 20; // changes original object's data
                obj = new MyClass(); // new reference (won’t affect original)
                obj.Value = 999;
            }

            static void ModifyByRef(ref MyClass obj)
            {
                obj = new MyClass(); // new reference (affects original)
                obj.Value = 999;
            }

            static void Main()
            {
                MyClass a = new MyClass();

                ModifyByValue(a);
                Console.WriteLine("After ModifyByValue: " + a.Value); // Output: 20

                ModifyByRef(ref a);
                Console.WriteLine("After ModifyByRef: " + a.Value);   // Output: 999
            }
        



        #endregion
        #region Q3.
        #endregion
        #region Q4.
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
