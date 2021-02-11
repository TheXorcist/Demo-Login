using System;

namespace Parts.PaswordCheck
{
    class PaswordCheck
    {
        public static bool chk(string a)
        {
            char[] chr = a.ToCharArray();
            int[] ar = new int[3] {0, 0, 0};
            foreach(char ch in chr)
            {
                if(Char.IsUpper(ch)==true)
                ar[0] =ar[0]+ 1;
                if(Char.IsLower(ch)==true)
                ar[1] =ar[1]+ 1;
                if(Char.IsDigit(ch)==true)
                ar[2] =ar[2]+ 1;
            }

            if(ar[0]>=1 && ar[1]>=1 && ar[2]>=1 && a.Length>=8)
            return true;
            else
            return false;

        }


    }
}