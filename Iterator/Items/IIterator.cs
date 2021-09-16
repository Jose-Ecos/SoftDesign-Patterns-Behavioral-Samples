namespace Iterator.Items
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
