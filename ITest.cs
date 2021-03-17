using System;

namespace pacmanascii
{
    interface ITest
    {
        virtual protected void writeOK()
        {

        }
        virtual protected void writeKO()
        {

        }
        abstract public bool test();
        virtual public void Main (string [] args)
        {

        }
    }

    class TestITest: ITest
    {
        public bool test()
        {
            return true;
        }

    }
    
}