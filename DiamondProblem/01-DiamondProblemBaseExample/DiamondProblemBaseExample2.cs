using System;

namespace DiamondProblem.DiamondProblemBaseExample2
{
    interface IAvo
    {
        void PrintIAvo();
    }
    interface IPai
    {
        void PrintIPai();
    }
    interface IMae
    {
        void PrintIMae();
    }
    public class Avo : IAvo
    {
        public void PrintIAvo()
        {
            Console.WriteLine("PrintIA method from class Avo.");
        }
    }

    public class Pai : IPai
    {
        public void PrintIPai()
        {
            Console.WriteLine("PrintIB method from class Pai.");
        }
    }

    public class Mae : IMae
    {
        public void PrintIMae()
        {
            Console.WriteLine("PrintIC method from class Mae.");
        }
    }

    public class Filho : IAvo, IPai, IMae
    {
        public void PrintIAvo()
        {
            Console.WriteLine("PrintIA method from class Filho.");
        }
        public void PrintIPai()
        {
            Console.WriteLine("PrintIB method from class Filho.");
        }
        public void PrintIMae()
        {
            Console.WriteLine("PrintIC method from class Filho.");
        }
    }

    class DiamondProblemExample2
    {
        public DiamondProblemExample2()
        {
            Avo objA = new Avo();
            objA.PrintIAvo();

            Filho obj = new Filho();
            obj.PrintIAvo();
            obj.PrintIPai();
            obj.PrintIMae();

            Console.WriteLine();
        }
    }
}
