namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Difference Between Passing Value Type by Value vs. by Reference
            static void ChangeValue(int x)
            {
                x = 100;
            }

            static void ChangeValueByRef(ref int x)
            {
                x = 100;
            }

            static void Main()
            {
                int a = 5;
                ChangeValue(a);
                Console.WriteLine("After by value: " + a);  // Output: 5

                ChangeValueByRef(ref a);
                Console.WriteLine("After by reference: " + a);  // Output: 100
            }
            #endregion
            #region Q2.
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
