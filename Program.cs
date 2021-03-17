using System;

namespace pacmanascii
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                switch (s)
                {
                    case "testchampspublic":
                        TestChampsPublic tcp = new TestChampsPublic("Test Champs Public");

                        tcp.Main(new string [0]);
                        break;

                    case "testproprietepublic":
                        TestProprietePublic tpp = new TestProprietePublic("Test Propriété Public");
                        tpp.Main(new string[0]);
                        break;
                    
                    case "testsumnentiers":
                        TestSumNEntiers sum = new TestSumNEntiers("Test Somme n entiers");
                        sum.Main(new string[0]);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
