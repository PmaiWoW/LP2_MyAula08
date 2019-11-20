using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        public static string ToRandomCase(this string s)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            // Em ciclo foreach
            // foreach (char c in s)
            // {
            //     if (rnd.NextDouble() > 0.5)
            //     {
            //         sb.Append(c.ToString().ToLower());
            //     }
            //     else
            //     {
            //         sb.Append(c.ToString().ToUpper());
            //     }
            // }

            // Em ciclo for (mais rápido)
            for(int i = 0; i < s.Length; i++)
            {
                //Em operador ternário
                sb.Append(rnd.NextDouble() > 0.5 ?
                    s[i].ToString().ToUpper() : s[i].ToString().ToLower());

                // Em if/else tradicional
                // if (rnd.NextDouble() > 0.5)
                // {
                //     sb.Append(s[i].ToString().ToLower());
                // }
                // else
                // {
                //     sb.Append(s[i].ToString().ToUpper());
                // }
            }

            return sb.ToString();
        }
    }
}
