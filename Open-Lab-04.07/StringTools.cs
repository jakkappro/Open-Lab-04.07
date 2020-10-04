using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] ret = original.ToCharArray();
            Array.Reverse(ret);
            return new string(ret);
        }
    }
}
