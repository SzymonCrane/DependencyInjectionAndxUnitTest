namespace DependencyInjectionTest
{
    public interface IWorker
    {
        void DoSomething(string message);
        string GetText(string message);
    }
}