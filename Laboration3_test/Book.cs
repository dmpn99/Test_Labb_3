namespace ConsoleApp10;

public class Book
{
    // Privata fält
    private string title;
    private int numOfPages;
    private string author;
    private string isbn;
    
    
    
    // Konstruktor
    public Book(string title, int numOfPages, string author, string isbn) // <-- default konstruktorn. Vi behöver ändra för att sätta värden
    {
        this.title = title;
        // Fyll på med parametrarna
        // i klassdiagrammet (UML)
        this.numOfPages = numOfPages;
        this.author = author;
        this.isbn = isbn;

        GenerateISBN();
        GetBookData();
        

    } 

    
    // Metod för att skapa upp ISBN
    private void GenerateISBN()
    {
        Random random = new Random();
        string isbnTemp = random.Next(100000000, 999999999).ToString();
        isbnTemp += $"-{random.Next(1, 9).ToString()}";
        this.isbn = isbnTemp;
        
    }

    // Metod för att hämta en sträng med bokdata
    public string GetBookData()
    {
        return $"Title: {title} \n Pages: {numOfPages} \n Författare: {author} ISBN: {isbn}";
    }
}