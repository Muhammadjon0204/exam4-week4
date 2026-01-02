using System;

namespace TASK2;

public class Library :ILibrary
{
    public List<Book> books=new List<Book>();
    public void AddBook(Book book)
    {
         books.Add(book);
    }

    public void DeleteBook(Book book)
    {
        try
        {
            books.Remove(book);
            if (books == null)
            {
                System.Console.WriteLine("We try to delete element but list is null.");
            }
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    public List<Book> DisplayBooks()
    {
        return books;
    }

    public List<Book> SearchByAuthor(string author)
    {
      List<Book> byAuthor=books.Where(book=>book.Author.ToLower().Contains(author.ToLower())).ToList();
      return byAuthor;
    }

    public List<Book> SearchByTitle(string title)
    {
       List<Book> byTitle=books.Where(book=>book.Title.ToLower().Contains(title.ToLower())).ToList();
      return byTitle; 
    }

    public virtual void UpdateBook(string title, string author)
    {
     System.Console.WriteLine("Updated");
    }
}
