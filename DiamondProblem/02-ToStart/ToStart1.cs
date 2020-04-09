using System;

namespace DiamondProblem.ToStart1
{
    public interface IA
    {
        void M();
    }
    public class C : IA
    {
        public void M()
        {
            Console.WriteLine("Print ToStartExample1: C.M : IA");
        }
    }
    
    public class ToStartExample1
    {
        public ToStartExample1()
        {
            var c = new C();
            c.M();
            Console.WriteLine();
        }
    }
}
