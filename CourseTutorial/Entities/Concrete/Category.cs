using Entities.Abstract;
using System.Text.Json.Serialization;

namespace Entities.Concrete;

public class Category: IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    [JsonIgnore]
    public virtual List<Course>? Courses { get; set; }

}
