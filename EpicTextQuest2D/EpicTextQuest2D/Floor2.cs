using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EpicTextQuest2D
{
    public class Floor2
    {
        public static void LayoutPrint(string[][] lays)
        {
            string[][] layout = new string[4][];
            layout[0] = new string[] { "[2]", "[ ]", "[ ]", "[ ]" };
            layout[1] = new string[] { "  ", "  ", "  ", "[ ]" };
            layout[2] = new string[] { "  ", "   ", "[ ]", " " };
            layout[3] = new string[] { " ", " ", "[ ]", "[*]" };
            foreach (string[] lay in layout)
            {
                foreach (string lay2 in lay)
                {
                    Console.Write($"{lay2}  ");
                }
                Console.WriteLine();
            }
        }


        public string[][] Layout 
        { 
            get 
            { 
                return new string[4][];
                Layout[0] = new string[] { "[2]", "[ ]", "[ ]", "[ ]" };
                Layout[1] = new string[] { "  ", "  ", "  ", "[ ]" };
                Layout[2] = new string[] { "  ", "   ", "[ ]", " " };
                Layout[3] = new string[] { " ", " ", "[ ]", "[*]" };
            }
        }
    }
}
