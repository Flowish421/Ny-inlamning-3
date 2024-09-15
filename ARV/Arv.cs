using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp3.ARV
{   // Huved klass (spelare)
    public class Player0
    {
        //ATTRUBUTER AV KLASSEN PLAYER
        public string Name;

        public int Nummer;

        public void Plays()
        {
            Console.WriteLine("Spelare0--{Flow}--{27}--");
            Console.WriteLine("Den har Spelare ska spela");

        }

    }

    public class Player1 : Player0
    {
        // NYA ATTRIBUTER + ALLA ATTRIBUTER FRAN ANIMAL

        public int Pro;
        public new void Benkad()  // Metod public new void (Är så kallad metod)
        {
            Console.WriteLine("Spelare2--{Alan}--{24}-");
            Console.WriteLine("Denna spelare ar benkad");
        }
    }
    public class player2()
    {
        public int trott;

        public new void benka1() // ny metod
        {
            Console.WriteLine("Spelare3--{Mario}--{28}--");
            Console.WriteLine("Denna spelaren ar I fotbolls planen redan");
            Console.ReadLine();
        }


    }




}
