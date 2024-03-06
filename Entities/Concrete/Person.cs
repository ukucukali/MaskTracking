using Entities.Abstract;

namespace Entities.Concrete;

public class Person : IEntity
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
        
    public long NationalityNumber { get; set; }
    
    public short BirthYear { get; set; }
} 
