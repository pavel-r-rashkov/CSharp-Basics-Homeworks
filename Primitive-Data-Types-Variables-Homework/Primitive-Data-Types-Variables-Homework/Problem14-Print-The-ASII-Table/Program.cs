using System;
using System.Text;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        string print = null;
        for (int i = 0; i <= 255; i++)
        {
            char ch = (char)i;
            if (char.IsWhiteSpace(ch))
            {
                switch (ch)
                {
                    case '\n':
                        print = "\\n"; break;
                    case '\v':
                        print = "\\v"; break;
                    case '\f':
                        print = "\\f"; break;
                    case '\t':
                        print = "\\t"; break;
                    case '\r':
                        print = "\\r"; break;
                    case ' ':
                        print = "\' \'"; break;
                }              
            }
            else if (char.IsControl(ch))
            {
                print = "control";             
            }
            else
            {
                print = ch.ToString();
            }
            Console.WriteLine(i.ToString().PadRight(4) + "-----> " + print); 
        }

    }
}

