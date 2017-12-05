using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testffs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> liste1 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                liste1.Add(random.Next(1, 10));
            }

            List<int> matchList = new List<int>();
            List<int> noMatchList = new List<int>();

            Console.WriteLine("liste1:");
            for (int i = 0; i < liste1.Count; i++)
            {
                Console.WriteLine(i + ". " + liste1[i]);

            }

            Console.WriteLine(" ");
            Console.WriteLine("matchList:");

            for (int i = 0; i < matchList.Count; i++)
            {
                Console.WriteLine(i + ". " + matchList[i]);
            }
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int points = 0;

            for (int i = 0; i < liste1.Count; i++)
            {
                for (int j = 0; j < liste1.Count; j++)
                {
                    Console.WriteLine("Checking index " + i + " with index " + j);
                    if (j == i)
                    {
                        Console.WriteLine("NULL!");
                        continue;
                    }
                    //matching
                    else if (liste1[j] == liste1[i])
                    {
                        Console.WriteLine("Matchpoint!");
                        points = (points + 1);
                        matchList.Add(liste1[i]);
                        liste1.RemoveAt(i);
                        matchList.Add(liste1[j - 1]);
                        liste1.RemoveAt(j - 1);
                    }
                    else
                    {
                        Console.WriteLine("No matchpoint!");
                    }
                }
            }

            Console.WriteLine("liste1:");

            for (int i = 0; i < liste1.Count; i++)
            {
                Console.WriteLine(i + ". " + liste1[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("matchList:");

            for (int i = 0; i < matchList.Count; i++)
            {
                Console.WriteLine(i + ". " + matchList[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("noMatchlist:");

            for (int i = 0; i < noMatchList.Count; i++)
            {
                Console.WriteLine(i + ". " + noMatchList[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine(points);
            Console.ReadKey();
        }
    }
}