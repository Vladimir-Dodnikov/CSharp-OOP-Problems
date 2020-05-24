using MyTestingFramework.Exceptions;
using System.Collections;

namespace MyTestingFramework.Asserts
{
    public abstract class MyAssert
    {
        public static void AreEqual(object expected, object actual)
        {
            var result = Comparer.DefaultInvariant.Compare(expected, actual);

            if (result != 0)
            {
                throw new MyTestException();
            }
        }
    }
}
