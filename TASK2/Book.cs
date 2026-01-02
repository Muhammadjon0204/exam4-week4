using System;

namespace TASK2;

public class Book : Library
{

public int Id{get; set;}
public string Title{get; set;}=string.Empty;
public string Author{get; set;}=string.Empty;

    public override void UpdateBook(string title, string author)
    {
        Title=title;
        Author=author;
    }

}
