/***************************************************************************/
// Reference types
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
/***************************************************************************/


/***************************************************************************/
// Class
/***************************************************************************/
public class ExampleClassReferenceType {
    // Contructor
    public ExampleClassReferenceType(){

    }

    // Constants
    const int a = 0;

    // Fields
    private int _b;
    public int B {
        get { return _b; }
        set { _b = value; }
    }

    // Method
    public int incrementB(int increment){
        return _b + increment;
    }

    // Finalizer
    ~ExampleClassReferenceType() {
        _b = 0;
    }

    // Properties 
    public int c { get; set; }

    //Indexers
    //Operators overload
    //Events
    //Delegates
    //Classes
    //Interfaces
    //Structure types
    //Enumeration types
}


/***************************************************************************/
// Interface
/***************************************************************************/
interface ISampleInterface
{
    void SampleMethod01();
    void SampleMethod02();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod01()
    {
        // Method implementation.
    }

    public void SampleMethod02()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod01();
    }
}

/***************************************************************************/
// Record type
/***************************************************************************/
public record Person(string FirstName, string LastName);