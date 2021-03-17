Pour lancer tout les test entrée la commande make dans un cmd

Pour tester un par un vous entrer la commande make suivit du parametre à tester : 

- testchampspublic 
- testproprietepublic 
- testsumnentiers


QUESTION 1:
a - Dans un petit paragraphe, à l’aide de documentation et d’autre expérimentations expliquez à quoi peut servir cette outil. 
b - Quel alternative lui connaissez vous pour enchaîner des commandes syst\`eme? 
c - Quels sont les différences entre ces deux manières de faire?

a - l'outil make est très utile car il permet d'executer et automatiser des commande (alternative à "dotnet run").
b - il existe aussi l'outil Scon 
c - il n'y a pas tellement de différence, elle permettent tout deux à compiler un programme et l'executé. 

--------------------------------------------------------------------------------------------------------------------------------

Question 2 : 
    Ecrire la classe le plus simple possible qui implémente cette interface. 

On déclare une fonction test public qui est un booléen et on lui fait retourner True ou False.

--------------------------------------------------------------------------------------------------------------------------------

Question 3 : 
    Implémentez la classe ChampsPublic dans le fichier ChampsPublic.cs.

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

--------------------------------------------------------------------------------------------------------------------------------

Question 4 : 
    L’implémentation du programme principale est la suivante. Expliquer son intérêt.

Il permet d'implementer un paramètre à chaque fonction graçe au foreach.
Si on execute la commande make celle-ci nous renvoie : [ok] : Test Champs Public  

--------------------------------------------------------------------------------------------------------------------------------

Question 5 : 
    Expliquer l’architecture.

Program.cs <--- TestChampsPublic.cs <--- AbstractTest.cs <--- ITest.cs 
                                         ChampsPublic.cs

--------------------------------------------------------------------------------------------------------------------------------

Question 6 : 
    La classe ProprietePublic

class ProprietePublic
    {
        public int Proprietepublic 
        {
            get; set;
        }
    }

--------------------------------------------------------------------------------------------------------------------------------

Question 7 : 
    La classe TestProprietePublic

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

--------------------------------------------------------------------------------------------------------------------------------

Question 8 : 
    La classe SumNEntiers

class SumNEntiers
    {
        private int n = 42;
        
        public int N 
        {
            get => n;
            set => n = value;
        }

        private int sum()
        {
            int i = 0;
            int sum = 0;
            while (i < n) 
            {
                sum = sum + i;
                i = i+1;
            }
            return sum;
        }
    }

--------------------------------------------------------------------------------------------------------------------------------

Question 9 : 
    La classe TestSumNEntiers

class TestSumNEntiers : AbstractTest
    {
        public TestSumNEntiers(string name) : base(name) 
        {

        }

        private int oracle(int n)
        {
            int test;
            if (n == 0) 
            {
                test = 0;
            } 
            else 
            {
                int n1 = n-1;
                test = (n1*(n1+1))/2;
            }
            return test;
        }
        
        override public bool test()
        {
            SumNEntiers sum = new SumNEntiers();

            if (sum.N == 42)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }

--------------------------------------------------------------------------------------------------------------------------------

Question 10 : 
    Modifier la classe du programme principale en conséquence

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

--------------------------------------------------------------------------------------------------------------------------------

Question 11 : 
    Modifier le Makefiles

all: testchampspublic testproprietepublic testsumnentiers

testchampspublic:
	@dotnet run $@

testproprietepublic:
	@dotnet run $@
#$@ + le nom de la cible.

testsumnentiers:
	@dotnet run $@

.PHONY: all testchampspublic

@dotnet run (execute la cible avant commande dotnetrun dans le cmd)