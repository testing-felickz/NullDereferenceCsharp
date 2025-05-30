#pragma warning disable CS8600, CS8602, CS8625 // Disable nullable warnings

namespace NullDereferenceCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unused variable - should trigger a standard CodeQL rule

            // BEFORE scenario - This will cause a NullReferenceException
            TestObject theObj = null;

            // This will throw NullReferenceException
            Console.WriteLine(theObj.TheInt);

            // The code below will never be reached due to the exception above

            // AFTER scenario
            TestObject theObj2 = new TestObject();

            Object2 object2 = new Object2();
            Object3 object3 = new Object3();
            Object1 object1 = new Object1();

            // This will throw another NullReferenceException because object1.TheObject is null
            object2.DoThePrint(object1);

            Console.WriteLine(theObj2.TheInt);
        }
    }

    public class TestObject
    {
        public int TheInt = 42;
    }
}
