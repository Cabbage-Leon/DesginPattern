namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 迭代器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITerator<T>
    {
        T First();

        T Next();

        bool HasNext();
    }
}
