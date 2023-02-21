using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._23
{
    internal class Program
    {
        delegate bool Func_1(int x);
        delegate int Func_2(int x);
        delegate int Func_3(int x);
        delegate bool Func_4(int x);
        delegate int Func_5(int[] x);
        delegate int Func_6(int[] x);
        delegate void Func_7(int[] x);
        static void Main(string[] args)
        {
            #region 1
            Func_1 func_1 = delegate (int x) 
            {
                return (x % 2 == 0 && x != 0);
            };
            Console.WriteLine(func_1(2));
            #endregion

            #region 2
            Func_2 func_2 = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(func_2(2));
            #endregion

            #region 3
            Func_3 func_3 = x => x * x * x;
            Console.WriteLine(func_3(2));
            #endregion

            #region 4
            Func_4 func_4 = x => x == 256;
            Console.WriteLine(func_4(256));
            #endregion

            #region 5
            int[] arr = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            Func_5 func_5 = (int[] x) =>
            {
                int buf = arr[0];
                for(int i = 0; i < x.Length; i++)
                    if (buf < arr[i])
                        buf = arr[i];
                return buf;
            };
            Console.WriteLine(func_5(arr));
            #endregion

            #region 6
            Func_6 func_6 = (int[] x) =>
            {
                int buf = arr[0];
                for (int i = 0; i < x.Length; i++)
                    if (buf > arr[i])
                        buf = arr[i];
                return buf;
            };
            Console.WriteLine(func_6(arr));
            #endregion

            #region 7
            Func_7 func_7 = (int[] x) =>
            {
                for (int i = 0; i < x.Length; i++)
                    if (x[i] % 2 != 0)
                        Console.Write(x[i] + " ");
                Console.WriteLine();
            };
            func_7(arr);
            #endregion
        }
    }
}
