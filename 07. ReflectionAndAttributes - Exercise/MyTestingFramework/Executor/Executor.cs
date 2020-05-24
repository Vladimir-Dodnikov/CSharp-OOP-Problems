using MyTestingFramework.Attributes;
using MyTestingFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyTestingFramework.Executor
{
    public class Executor
    {
        public void Execute(Assembly assembly)
        {
            StringBuilder sb = new StringBuilder();

            var testClasses = assembly
            .GetTypes()
            .Where(t => t.GetCustomAttributes((typeof(MyTestFixtureAttribute)))
            .Any());

            foreach (var type in testClasses)
            {
                var testMethods = type
                    .GetMethods()
                    .Where(t => t.GetCustomAttributes((typeof(MyTestAttribute)))
                    .Any());

                var instance = Activator.CreateInstance(type);

                foreach (var test in testMethods)
                {
                    try
                    {
                        test.Invoke(instance, new object[] { });
                        sb.AppendLine($"{test.Name} passed successfully!");
                    }
                    catch (TargetInvocationException ex)
                    {
                        if (ex.InnerException.GetType() == typeof(MyTestException))
                        {
                            sb.AppendLine($"{test.Name} passed unsuccessfully!");
                        }

                    }
                }
            }

            File.AppendAllText($"../../../TestingResult.txt",
                sb.ToString().TrimEnd());
        }
    }
}
