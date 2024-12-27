namespace DesignPattern.IteratorPattern.Interfaces;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
