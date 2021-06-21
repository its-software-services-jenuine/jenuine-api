
namespace Its.Jenuiue.Api.Actions
{
    public interface IFactoryActions
    {
        public T CreateAction<T>()  where T : new();
    }
}
