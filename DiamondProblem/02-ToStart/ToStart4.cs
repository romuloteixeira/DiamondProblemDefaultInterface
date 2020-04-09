using System;

namespace DiamondProblem.ToStart4
{
    //public interface IA0
    //{
    //    public virtual void M0()
    //    {
    //        Console.WriteLine("IA0.M0");
    //    }
    //}

    public interface IPai// : IA0
    {
        //public void M0()
        //{
        //    Console.WriteLine("IA.M0");
        //}

        public virtual void M()
        {
            Console.WriteLine("IA.M");
        }

        public virtual void M1()
        {
            Console.WriteLine("IA.M1");
        }

        public static void M2()
        {
            Console.WriteLine("IA.M2");
        }

        void Sum();
    }

    public interface IMae : IPai//, IA0
    {
        //public void M0()
        //{
        //    Console.WriteLine("IB.M0");
        //}

        public void M()
        {
            Console.WriteLine("IB.M");
        }

        public void M2()
        {
            IPai.M2();
            Console.WriteLine("IB.M2");
        }
    }

    public class Filho : IPai, IMae
    {
        //public void M0()
        //{
        //    Console.WriteLine("AnyClass.M0");
        //}

        //public void M1()
        //{
        //    Console.WriteLine("AnyClass.M1");
        //}

        public void Sum()
        {
        }
    }

    public class ToStartExample4
    {
        public ToStartExample4()
        {
            Console.WriteLine("It's writing down IA.");
            IPai iA = new Filho();
            iA.M();
            iA.M1();

            IPai.M2();
            //iA.M0();

            Console.WriteLine();

            Console.WriteLine("It's writing down IB.");
            IMae iB = new Filho();
            IPai david = (IPai)iB;
            david.M1();
            iB.M();
            iB.M1();
            iB.M2();

            //IB.M2();
            //iB.M0();

            //AnyClass anyClass1 = new AnyClass();
            //var anyClass1 = new AnyClass();
            //anyClass1.M();

            Console.WriteLine();
        }
    }
}
