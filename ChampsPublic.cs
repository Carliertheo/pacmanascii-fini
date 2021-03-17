using System;

namespace pacmanascii
{
    class ChampsPublic
    {
        public int champspublic = 0;
    }
    
    class TestChampsPublic : AbstractTest
    {
        public TestChampsPublic(string name) : base(name)
        {

        }
        override public bool test()
        {
            ChampsPublic cp = new ChampsPublic();
            cp.champspublic = 42;
            if(cp.champspublic ==42)
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