namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 定义存储、添加、删除聚合对象以及创建迭代器对象的接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAggregate<T>
    {
        void Add(T obj);

        void Remove(T obj);

        ITerator<T> GetIterator();
    }
}
