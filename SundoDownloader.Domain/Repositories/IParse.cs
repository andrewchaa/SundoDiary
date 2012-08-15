namespace SundoDiary.Domain.Repositories
{
    public interface IParse<T>
    {
        T Parse(string content);
    }
}