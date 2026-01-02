//TASK6

using TASK2;

Library library=new Library();

Book book1=new Book()
{
    Id=1,
   Title="1001Night",
   Author="Shakespire"
};
Book book2=new Book()
{
    Id=2,
    Title="1002Night",
    Author="Shakespire"
};
Book book3= new Book()
{
  Id=3,
  Title="Matematika",
  Author="Nabiev"  
};
Book book4 = new Book()
{
  Id=4,
  Title="Odina",
  Author="Aini"  
};

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);

System.Console.WriteLine("====================== All books ======================");
var cnt=library.DisplayBooks();
foreach (var book in cnt)
{
    System.Console.WriteLine($"{book.Title} by {book.Author}");
}

System.Console.WriteLine("====================== After Deleting ======================");
library.DeleteBook(book2);

var cnt2=library.DisplayBooks();
foreach (var book in cnt2)
{
    System.Console.WriteLine($"{book.Title} by {book.Author}");
}

System.Console.WriteLine("====================== After Updating ======================");
book1.UpdateBook("1000Night","Goggins");
book2.UpdateBook("1003Night","Grimm");
var updated=library.DisplayBooks();
foreach (var book in updated)
{
        System.Console.WriteLine($"{book.Title} by {book.Author}");
}

System.Console.WriteLine("====================== By author ======================");
var byAu=library.SearchByAuthor("Gog");
foreach (var book in byAu)
{
         System.Console.WriteLine($"{book.Title} by {book.Author}");   
}

System.Console.WriteLine("====================== By title ======================");
var byTi=library.SearchByTitle("Matem");
foreach (var book in byTi)
{
         System.Console.WriteLine($"{book.Title} by {book.Author}");   
}


System.Console.WriteLine("====================== Last Expierence ======================");
var all=library.DisplayBooks();
foreach (var book in all)
{
    System.Console.WriteLine($"{book.Title} by {book.Author}");
}