namespace SundoDiary.Domain.Repositories
{
    public interface IRepository
    {
        DataPage Get(string name);
    }
}