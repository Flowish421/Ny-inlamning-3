namespace ConsoleApp3.Inkapsling
{

    public class Shop
    {
        // Detta är en privat attribut som vi skyddar från resten av apper och avändare
        // Vi kommer åt denna bara med hjälp av public metoder eller public attributer
        private string name;

        // Konstruktör - den säger att när vi skapar ett object av klassen Shop, att vi måste specificera attributen !!!
        public Shop(string name)
        {
            Name = name;
        }

        // Nu gör vi ett public metod för att komma åt privata attributer
        public string Name
        {
            get { return Name; }
            set { name = value; }
        }

    }
}
