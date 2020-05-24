using MyTestingFramework.Executor;
using System.Reflection;

namespace ConsoleApp_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Executor ex = new Executor();
            ex.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
