using System;

namespace pacmanascii
{
    class ProprietePublic
    {
        public int Proprietepublic 
        {
            get; set;
        }
    }

    class TestProprietePublic : AbstractTest
    {
        public TestProprietePublic(string name) : base(name) 
        {

        }

        override public bool test()
        {
            ProprietePublic pp = new ProprietePublic();
            pp.Proprietepublic = 42;
            if (pp.Proprietepublic == 42)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}