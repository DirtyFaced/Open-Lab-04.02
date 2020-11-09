using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            char[] vysledok = new char[original.Length * 2];
            for (int i = 0; i < original.Length; i++)
            {
                char nowchar = original[i];
                vysledok[(i + 1) * 2 - 2] = nowchar;
                vysledok[(i + 1) * 2 - 1] = nowchar;
            }
            string vysledokstr = new string(vysledok);
            return vysledokstr;
        }
    }
}
