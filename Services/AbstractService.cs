using AbstractServiceInterfaceInyectionDemo.Models;

namespace AbstractServiceInterfaceInyectionDemo.Services;

public class AbstractService<T> : IAbstractService<T>
{
    public string Write(T entity)
    {
        if (entity is Plant)
            return $"This is a plant. {entity}";

        if (entity is Animal)
            return $"This is an animal. {entity}";

        return string.Empty;
    }
}
