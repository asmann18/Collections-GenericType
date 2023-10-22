using PracticeConsoleApp.Models.Common;

namespace PracticeConsoleApp.Models;

public class Book:BaseEntity
{
    static int count = 0;

    public string Author { get; set; }
    public Category Category { get; set; }
    public Book(string name,string author,Category category):base(name)
    {
        Id = ++count;
        Author = author;
        Category = category;
    }

}
