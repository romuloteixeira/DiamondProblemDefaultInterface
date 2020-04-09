using System;

namespace DiamondProblem.DiamondProblemBaseExample3
{
    interface IA
    {
        void PrintIA();
    }
    interface IB
    {
        void PrintIB();
    }
    interface IC
    {
        void PrintIC();
    }
    public class A : IA
    {
        public void PrintIA()
        {
            Console.WriteLine("PrintIA method from class A.");
        }
    }

    public class B : IB
    {
        public void PrintIB()
        {
            Console.WriteLine("PrintIB method from class B.");
        }
    }

    public class C : IC
    {
        public void PrintIC()
        {
            Console.WriteLine("PrintIC method from class C.");
        }
    }

    public class D : IA, IB, IC
    {
        public void PrintIA()
        {
            Console.WriteLine("PrintIA method from class D.");
        }
        public void PrintIB()
        {
            Console.WriteLine("PrintIB method from class D.");
        }

        public void PrintIC()
        {
            Console.WriteLine("PrintIC method from class D.");
        }
    }

    class DiamondProblemExample3
    {
        public DiamondProblemExample3()
        {
            D obj = new D();
            obj.PrintIA();
            obj.PrintIB();
            obj.PrintIC();

            Console.WriteLine();
        }
    }
}
