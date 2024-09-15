namespace ConsoleApp3.Polymorphism
{

    // Polymorphism exempel
    //Huved klassen
    public class Skola
    {
        public string Name;

        public string Klassrum;

        public virtual void StartaKlassrum()
        {


            Console.WriteLine("Klassens Lektion Starta");


        }

    }
    public class Klass : Skola
    {

        public override void StartaKlassrum()
        {

            Console.WriteLine("Lektionen for WebbDesgin  Startar");

        }

    }


    public class Klass2 : Skola
    {

        public override void StartaKlassrum()
        {

            Console.WriteLine("Lektionen for Programmering  Startar");

        }

    }


}