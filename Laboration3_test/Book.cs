namespace ConsoleApp10;

public class TemperatureCalculator
{
    // Privata fält
    private string datum;
	private double temp;
    
    
    // Konstruktor
    public Book(string datum) // <-- default konstruktorn. Vi behöver ändra för att sätta värden
    {
        this.datum = title;
        // Fyll på med parametrarna
        // i klassdiagrammet (UML)

        FindMaxTemperature();
        
    } 

    
    // Metod för att hitta max temperaturen
    private void FindMaxTemperature()
    {
        Random random = new Random();
        string isbnTemp = random.Next(-10, 30).ToString();
        maxTemp += $"-{random.Next(1, 9).ToString()}";
        this.temp = maxTemp;
		return $" Max temperaturen: {maxTemp);
        
    }

    // Metod för att hämta en sträng med bokdata
    public string GetBookData()
    {
        return $" Title: {title} \n Pages: {numOfPages} \n Författare: {author} \n ISBN: {isbn} \n";
    }
}