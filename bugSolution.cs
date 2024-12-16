public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property to 0

    public void MyMethod()
    {
        int value = MyProperty * 2; // No longer a risk of NullReferenceException
    }

    //Alternatively, provide a constructor to initialize the property:
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }
} 