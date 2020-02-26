using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(int param)
        {
            param = 425;
            Console.WriteLine($"param is now  {param} in Value() method");
        }
        public static void Reference(WrappedInt param)
        {
            param.Number = 452;
            param.Bnumber = 52;
        }
        public static void Value2(ref int param)
        {
            param = 462;
        }
    }
}
