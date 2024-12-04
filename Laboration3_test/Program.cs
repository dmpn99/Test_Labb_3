namespace ConsoleApp10;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new("Boken om livet", 35, "Fredrik Domert", "123456789-1");
        Book book2 = new("El-cyklar, Strava och allt där emellan", 5000, "Pär Hedström", "123456789-2");

        Book[] myBooks = new Book[2]; // skapar en ny array
        myBooks[0] = book1; // lägger in Book-objektet i arrayen på olika positioner
        myBooks[1] = book2;
        
        
        //Loopar igenom arrayen i en for-loop
        for (int i = 0; i < myBooks.Length; i++)
        {
            //för varje varv i loopen skriver vi ut data om bokobjektet vi har
            // på den i:te positionen
            Console.WriteLine(myBooks[i].GetBookData());
        }
    }
}