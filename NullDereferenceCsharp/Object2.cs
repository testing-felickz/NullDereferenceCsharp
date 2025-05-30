namespace NullDereferenceCsharp
{
    public class Object2
    {
        public int TheInt = 3;

        public void DoThePrint(Object1 theObj)
        {
            // This will cause a NullReferenceException when TheObject is null
            theObj.TheObject.DoTheWork();
        }
    }
}
