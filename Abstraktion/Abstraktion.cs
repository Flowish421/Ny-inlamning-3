namespace ConsoleApp3.Abstraktion
{
    // abstraktion
    // Huvedklass abstrakt

    public abstract class Boll
    {
        public abstract void Basketboll();
    
    }

    //SUBKLASS
    public class Fotboll : Boll
    {

        public override void Basketboll()
        {

            Console.WriteLine("Fotboll");

        }
    }
}
