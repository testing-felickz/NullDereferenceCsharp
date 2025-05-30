using System;

#pragma warning disable CS8600, CS8602, CS8625 // Disable nullable warnings

namespace NullDereferenceCsharp
{
    public class Object1
    {
        public Object3 TheObject = null;
    }

    public class Object2
    {
        public int TheInt = 3;

        public void DoThePrint(Object1 theObj)
        {
            theObj.TheObject.DoTheWork();
        }
    }

    public class Object3
    {
        public void DoTheWork() { }
    }

    public class TestObject
    {
        public int TheInt = 42;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Unused variable - should trigger a standard CodeQL rule

                TestObject theObj = null; // This line is null on the left side

                Console.WriteLine(theObj.TheInt); // This will throw a NullReferenceException



                TestObject theObj2 = new TestObject(); // Now properly initialized

                Object2 object2 = new Object2();
                Object3 object3 = new Object3();
                Object1 object1 = new Object1(); // TheObject is null

                object2.DoThePrint(object1); // This will throw a NullReferenceException

                Console.WriteLine(theObj2.TheInt);

        }
    }
}
