using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    [JsonIgnore]
    public virtual Category? Category { get; set; }
    [JsonIgnore]
    public virtual Instructor? Instructor { get; set; }

}
