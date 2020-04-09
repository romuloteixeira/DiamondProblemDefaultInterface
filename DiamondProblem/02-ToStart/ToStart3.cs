using System;

namespace DiamondProblem.ToStart3
{
    public interface IA
    {
        virtual void Print() 
        { 
            Console.WriteLine("IA.M"); 
        }
    }
    public interface IB : IA
    {
        //override void IA.Print() { Console.WriteLine("IB.M"); }
    }
    public interface IC : IA
    {
        //override void IA.Print() { Console.WriteLine("IC.M"); }
    }

    //public abstract class C : IB, IC { } // error: no most specific override for 'IA.M'
    public interface ID : IB, IC { }
    //public class C1 : ID { } // error: no most specific override for 'IA.M'


    public abstract class D : IA, IB, IC // ok
    {
        public abstract void Print();
    }

    public class D1 : D
    {
        public override void Print()
        {
        }
    }

    public class ToStartExample3
    {
        public ToStartExample3()
        {
            var d1 = new D1();
            d1.Print();

            Console.WriteLine("See this code (ToStartExample3)... Override not permitted");
        }
    }
}
