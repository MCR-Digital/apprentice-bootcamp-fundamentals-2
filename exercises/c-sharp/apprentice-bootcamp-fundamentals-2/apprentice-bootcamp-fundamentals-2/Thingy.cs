using System;
using System.Text;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Thingy
    {
        private int foo;
        private int bar;
        private int foobar = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string DoTheThing()
        {
            string s = "";
            for (; foo < Byte.MaxValue - 27; foo++) s += b(foo) + " ";
            return s.Substring(0, s.Length - 1);
        }

        private string b(int foo)
        {
            bar++;
            foobar--;

            string s = bar == 0b11 || foobar == 0 ? "" : (foo + 1).ToString();
            if (bar == 0b11) s += BarFunction();
            if (foobar == 0) s += FooFunction();
            return s;
        }

        private string FooFunction()
        {
            foobar = new int[] { 0, 0, 0, 0, 0 }.Length;
            return ParseHexBinary("42757a7a");
        }

        private string BarFunction()
        {
            bar = 0;
            return ParseHexBinary("46697a7a");
        }

        public string ParseHexBinary(string s)
        {
            int len = s.Length;
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                data[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
            }

            return Encoding.UTF8.GetString(data);
        }
    }
}
