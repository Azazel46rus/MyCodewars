using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeBlogLesons
{   

    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.AlphabetPosition("The sunset sets at twelve o' clock.");

        }

        public static class Kata
        {
            public static string AlphabetPosition(string text)
            {
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                text = text.ToUpper();
                Regex reg = new Regex("[^a-zA-Z']");
                text = reg.Replace(text, string.Empty);
                char[] chars = text.ToCharArray();
                int index;
                string[] indexes = new string[chars.Length];
                

                for (int i = 0; i < chars.Length; i++)
                {   


                    index = Array.IndexOf(alpha, chars[i]);

                    if (index == -1)
                    {
                        continue;
                    }
                    else
                    {   string temp = Convert.ToString(index + 1);
                        indexes[i] = temp;
                    }
                    
                }

                StringBuilder sb = new StringBuilder(indexes.Length);

                foreach (var item in indexes)
                {
                    sb.Append(item + " ");
                }

                text = sb.ToString();
                
                Console.WriteLine(text);

                return text;
            }
        }
    }
}