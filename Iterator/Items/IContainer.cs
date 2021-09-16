namespace Iterator.Items
{
    public interface IContainer<T>
    {
        IIterator<T> CreateIterator();
    }
}
