using System;

namespace DiamondProblem.DiamondProblemBaseExample1
{
    public interface IWriter
    {
        void Print();
    }

    public abstract class Avo
    {
        public readonly string baseText = "Print method of class {0}.";
    }

    public class Pai : Avo, IWriter
    {
        public virtual void Print()
        {
            Console.WriteLine(string.Format(baseText, "Pai"));
        }
    }

    public class Filho : Pai, IWriter
    {
        public override void Print()
        {
            Console.WriteLine(string.Format(baseText, "Filho"));
        }
    }

    public class Mae : Avo, IWriter
    {
        public void Print()
        {
            Console.WriteLine(string.Format(baseText, "Mae"));
        }
    }

    //public class Filho2 : Pai, Mae
    //{
    //}

    class DiamondProblemExample1
    {
        public DiamondProblemExample1()
        {
            //Pai obj = new Pai();
            //Filho obj = new Filho();
            Mae obj = new Mae();
            //Neto obj = new Neto();
            obj.Print();

            Console.WriteLine();
        }
    }
}
