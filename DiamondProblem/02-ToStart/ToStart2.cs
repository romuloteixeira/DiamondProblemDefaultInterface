using System;

namespace DiamondProblem.ToStart2
{
    public interface IA
    {
        public void Print()
        {
            Console.WriteLine("Print ToStartExample2: C.M : IA");
        }
    }
    public class C : IA
    {
    }

    public class ToStartExample2
    {
        public ToStartExample2()
        {
            //var c = new C();
            //C c = new C();
            IA c = new C();

            c.Print();

            Console.WriteLine();
        }
    }
}
