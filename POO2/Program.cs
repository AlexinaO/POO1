using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new A1();
            var a2 = new A2();

            var b = new B();
            var b1 = new B1();
            var b2 = new B2();
            var b3 = new B2();

            a1.Methode();
            a2.Methode();

            b.Methode();
            b1.Methode();
            b2.Methode();
            b3.Methode();

            Console.ReadKey();
        }
        public abstract class A
        {
            public abstract void Methode();
        }

        public class A1 : A
        {
            public override void Methode()
            {
                Console.WriteLine("A1");
            }
        }

        public class A2 : A
        {
            public override int nombre
            {
                Console.WriteLine("A2");
            }

        }

        public class B
        {
            public virtual void Methode()
            {
                Console.WriteLine("B");

            }
        }

        public class B1:B
        {
            public override void Methode()
            {
                Console.WriteLine("B1");
            }
        }

        public class B2:B
        {

        }

        public class B3 : B
        {
            public override void Methode()
            {
                base.Methode();
                Console.WriteLine("B3");
            }
        }
    }
}
