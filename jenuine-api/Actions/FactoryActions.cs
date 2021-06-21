namespace Its.Jenuiue.Api.Actions
{
    public class FactoryActions : IFactoryActions
    {
        public T CreateAction<T>() where T : new()
        {
            T instance = new T();
            return instance;
        }
    }
}
