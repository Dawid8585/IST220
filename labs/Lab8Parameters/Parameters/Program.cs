#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 58;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);
            Console.WriteLine("--------------------------");
            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine(wi.Bnumber);
            Console.WriteLine("--------------------------");
            int j = 1776;
            Console.WriteLine(j);
            Pass.Value2(ref j);
            Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
