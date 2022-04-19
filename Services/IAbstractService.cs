namespace AbstractServiceInterfaceInyectionDemo.Services;

public interface IAbstractService<T>
{
    string Write(T entity);
}
