using System;

namespace MulticastDelegate
{   //multicast delegates
    public delegate void MultiDelegate();
    class SayHi
    {
        static public void SayHello()
        {
            Console.WriteLine("Helloo..");
        }
        static public void SayHola()
        {
            Console.WriteLine("Hola...");
        }
        static public void SayCiao()
        {
            Console.WriteLine("Ciao..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MultiDelegate md1 = new MultiDelegate(SayHi.SayHello);
            MultiDelegate md2 = new MultiDelegate(SayHi.SayHola);
            MultiDelegate md3 = new MultiDelegate(SayHi.SayCiao);
            md1();
            md2();
            md3();


        }
    }
}
