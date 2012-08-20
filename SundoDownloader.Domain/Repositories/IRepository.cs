using System.Collections.Generic;

namespace SundoDiary.Domain.Repositories
{
    public interface IRepository<T>
    {
        T Get(string name);

        IEnumerable<T> List();
    }
}