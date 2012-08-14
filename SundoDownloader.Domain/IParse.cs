namespace SundoDiary.Domain
{
    public interface IParse<T>
    {
        T Parse(string content);
    }
}