using System;

namespace SimulareExamen3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un text!");
            string text=Console.ReadLine();
            while (text is null)
            {
                text = Console.ReadLine();
            }
            Console.WriteLine("Pentru a inlocui aparitiile unui sub-string" +
                " cu un alt sub-string tastati 1");
            Console.WriteLine("Pentru a elimina toate aparitiile unui sub-string" +
                " tastati 2");
            Console.WriteLine("Pentru a insera un substring pe o pozitie data" +
                " tastati 3");
            Console.WriteLine("Pentru a transforma toate literele mici în litere mari tastati 4");
            Console.WriteLine("Pentru a transforma toate literele mari în litere mici tastati 5");
            Console.WriteLine("Pentru a afisa textul tastati 6");
            Console.WriteLine("Pentru a inchide programul tasteaza 0");

            int nr =Convert.ToInt32(Console.ReadLine());

            while (nr != 0)
            {
                if (nr == 1) text = Replace(text);
                else if (nr == 2) text = Remove(text);
                else if (nr == 3) text = Insert(text);
                else if (nr == 4) text = ToUpper(text);
                else if (nr == 5) text = ToLower(text);
                else if (nr == 6) Console.WriteLine(text);
                else
                {
                    Console.WriteLine("Numarul introdus nu este corect, introduceti un alt numar!");
                }
                nr = Convert.ToInt32(Console.ReadLine());
            }

        }

        static string Replace(string text)
        {
            Console.WriteLine("Introduceti sub-stringul pe care vreti sa il inlocuiti!");
            string substring1= Console.ReadLine();
            Console.WriteLine("Introduceti sub-string cu care sa inlocuiti vechiul sub-string!");
            string substring2= Console.ReadLine();
            text = text.Replace(substring1, substring2);
            return text;
            
        }
        static string Remove(string text)
        {
            Console.WriteLine("Introduceti sub-stringul pe care vreti sa il stergeti!");
            string substring = Console.ReadLine(); 

            int i = text.IndexOf(substring);
            while (i >= 0)
            {
                text = text.Remove(i, substring.Length);
                i = text.IndexOf(substring);
            }
            return text;
        }

        static string Insert(string text)
        {
            Console.WriteLine("Introduceti sub-stringul pe care vreti sa il inserati!");
            string substring= Console.ReadLine();
            Console.WriteLine("Introduceti locatia unde vreti sa inserati noul substring!");
            int nr = Convert.ToInt32(Console.ReadLine());
            text = text.Insert(nr, substring);
            return text;
        }

        static string ToUpper(string text)
        {
           text = text.ToUpper();
            return text;
        }

        static string ToLower(string text)
        {
            text = text.ToLower();
            return text;
        }



    }
}
