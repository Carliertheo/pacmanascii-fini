using System;

namespace pacmanascii
{
    abstract class AbstractTest :ITest
    {
        public AbstractTest (string name)
        {
            this.Name = name;
        }
        public String Name 
        {
            get; private set;
        }
        virtual protected void writeOK()
        {
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Write(" [");
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Write("] : ");
        }
        virtual protected void writeKO()
        {
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Write(" [");
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.Write("KO");
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Write("] : ");
        }
        virtual public void Main(string[] args)
        {
            if(test())
            {
                writeOK();
                Console.WriteLine(this.Name);
            }
            else
            {
                writeKO();
                Console.WriteLine(this.Name);
            }
        }
        abstract public bool test();
    }
}