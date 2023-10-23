using System.Text;

namespace Essentials2.Library;

public class Person
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int Age { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Id: {Id}");
        sb.AppendLine($"FirstName: {FirstName}");
        sb.AppendLine($"LastName: {LastName}");
        sb.AppendLine($"Age: {Age}");

        return sb.ToString();
    }
}