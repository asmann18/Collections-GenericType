namespace PracticeConsoleApp.Models.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string Name { get; protected set; }
    public BaseEntity(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id}-{Name}";
    }
}
