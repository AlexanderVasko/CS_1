namespace Partial
{
    abstract class Class1
    {
        public abstract int AbstrMethod();

        public virtual int R => I;

        public int I { get; set; } = 50;

        public Class1()
        {

        }
        public Class1(int i)
        {

        }
    }
}
