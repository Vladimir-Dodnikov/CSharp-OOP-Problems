using MyTestingFramework.Attributes;
using MyTestingFramework.Asserts;
using NUnit.Framework;

namespace ConsoleApp_UnitTesting
{
    [MyTestFixture]
    public class PersonTests
    {
        [MyTest]
        public void Test1()
        {
            var person1 = new Person();
            var person2 = new Person();

            MyAssert.AreEqual(person1.Age, person2.Age);
        }
    }
}
