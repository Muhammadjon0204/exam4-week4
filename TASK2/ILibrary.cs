using System;

namespace TASK2;

public interface ILibrary
{

void AddBook(Book book);
List<Book> DisplayBooks();
void UpdateBook(string title,string author);
void DeleteBook(Book book);
List<Book> SearchByTitle(string title);
List<Book> SearchByAuthor(string title);

}
