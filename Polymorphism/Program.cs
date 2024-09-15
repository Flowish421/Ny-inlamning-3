using static ConsoleApp3.Polymorphism.Program;

namespace ConsoleApp3.Polymorphism
{
    internal class Program
    {
        static void main(string[] args)
        {

            Skola skola1 = new Skola();
            skola1.StartaKlassrum();

            Klass klass = new Klass();
            klass.StartaKlassrum();

            Klass2 klass2 = new Klass2();
            klass2.StartaKlassrum();
      


        }



    }

  
 


}
