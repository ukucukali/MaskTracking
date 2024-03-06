using Entities.Concrete;

namespace Business.Abstract;

public interface INationalityCheckService
{
    bool CheckPerson(Person person);
}
