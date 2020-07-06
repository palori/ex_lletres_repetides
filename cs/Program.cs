using System;
using System.Collections.Generic;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            fase1();
            fase2();
            fase3();
            fase4();
        }

        private static void title(string title)
        {
            Console.WriteLine($"\n\n---\n{title}:\n");
        }

        private static void fase1()
        {
            title("fase1");
            char[] name = {'P','a','u'};
            Console.WriteLine("Option 1:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"nom[{i}] = {name[i]}");
            }
            Console.Write("\nOption 2:\nname = {");
            foreach (char n in name)
            {
                Console.Write($"  '{n}'");
            }
            Console.WriteLine("  }");
        }

        private static void fase2()
        {
            title("fase2");
            var name = new List<char>();
            name.Add('P');
            name.Add('a');
            name.Add('1');
            name.Add('!');

            foreach (char n in name)
            {
                // SOURCE: http://www.asciitable.com/

                // lletres majúscules i minúscules (sense accents, dièresis...)
                if((n >= 65 && n<=90) || (n >= 97 && n<=122))
                {
                    // vocals
                    if(n=='A'||n=='E'||n=='I'||n=='O'||n=='U'||n=='a'||n=='e'||n=='i'||n=='o'||n=='u')
                    {
                        Console.WriteLine("VOCAL");
                    }
                    // consonants
                    else
                    {
                        Console.WriteLine("CONSONANT");
                    }
                }
                // números
                else if(n >= 48 && n<=57)
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
                else
                {
                    Console.WriteLine("Aquest caràcter no el reconeixo... :s");
                }
            }
        }

        private static void fase3()
        {
            title("fase3");
            var name = new List<char>();
            name.Add('P');
            name.Add('a');
            name.Add('1');
            name.Add('!');
            name.Add('I');
            name.Add('m');
            name.Add('m');
            name.Add('a');

            var characters = new Dictionary<char,int>();
            foreach (var n in name)
            {
                try
                {
                    characters[n] += 1;
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    characters.Add(n,1);
                }
            }

            // testing the algorithm (should be done as unit testing)
            var keys = characters.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine($"{key} = {characters[key]}");
            }
        }

        private static void fase4()
        {
            title("fase4");
            var name = new List<char>{'P','a','u'};
            var surname = new List<char>{'L','o','p','e','z'};

            var fullname = new List<char>(name.Count+1+surname.Count);
            fullname.AddRange(name);
            fullname.Add(' ');
            fullname.AddRange(surname);

            Console.Write("full name:");
            foreach (var fn in fullname)
            {
                Console.Write($" {fn}");
            }
        }
    }
}
