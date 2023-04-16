namespace P02_Challenge02;

public class Book
{
  public string Title { get; private set; }
  public string Author { get; set; }
  public string ISBN { get; private set; }
  public int YearPublication { get; set; }
  public string LiteraryStyle { get; set; }
  public int NumberPages { get; set; }
  public string PublicationCountry { get; set; }

  public Book(string title, string isbn)
  {
    Title = title;
    ISBN = isbn;
  }
}