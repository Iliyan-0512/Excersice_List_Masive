using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args )
        {
            List<string> list = Console.ReadLine().Split('!').ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Urgent")
                {
                    if (!list.Contains(tokens[1]))
                    {
                        list.Insert(0, tokens[1]);
                    }


                }
                else if (tokens[0] == "Unnecessary")
                {
                    if (list.Contains(tokens[1]))
                    {
                        list.Remove(tokens[1]);
                    }

                }
                else if (tokens[0] == "Correct")
                {
                    int index = list.IndexOf(tokens[1]);
                    if (list.Contains(tokens[1]))
                    {
                        
                        list.Insert(index,tokens[2]);
                        list.Remove(tokens[1]);
                    }

                }
                else if (tokens[0] == "Rearrange ")
                {
                    if (list.Contains(tokens[1]))
                    {
                        list.Remove(tokens[1]);
                        list.Add( tokens[1]);

                    }

                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
            //Console.ReadLine();
        }
    }
}
