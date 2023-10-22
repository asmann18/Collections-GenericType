using PracticeConsoleApp.Models.Common;

namespace PracticeConsoleApp.Models;

public class Category:BaseEntity
{
    static int count = 0;

    public Category(string name):base(name)
    {
        Id = ++count;  
    }
}
