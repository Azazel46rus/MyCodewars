using System;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kata.ToWeirdCase("This is a test");


        }

        public class Kata
        {
            public static string ToWeirdCase(string s)
            {   
                char [] chars = s.ToCharArray();
                StringBuilder sb = new StringBuilder(); 
                bool count = true;
                for (int i = 0; i < chars.Length; i++)
                {
       
                    if (Char.IsWhiteSpace(chars[i]))
                    {
                        sb.Append(chars[i]);
                        count = true;
                        
                    }
                    else
                    {
                        if (count == true)
                        {
                            char c = chars[i];
                            sb.Append(Char.ToUpper(c));
                            count = false;
                            
                        }
                        else
                        {
                            char c = chars[i];
                            sb = sb.Append(Char.ToLower(c));
                            count = true;
                        }
                        
                    }
                }
                s = sb.ToString();
                return s;

            }
        }
    }
}
