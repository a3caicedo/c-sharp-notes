using System.Text;
/***************************************************************************/
// Simple Types
/***************************************************************************/
internal class Program
{
    private static void Main(string[] args)
    {
        // Signed 8-bit integer
        TypeInfo((sbyte)0);
        // Signed 16-bit integer
        TypeInfo((short)0);
        //Signed 32-bit integer
        TypeInfo(0);
        //Signed 64-bit integer
        TypeInfo(0L);
        // Unsigned 8-bit integer
        TypeInfo((byte)0);
        // Unsigned 16-bit integer
        TypeInfo((ushort)0);
        // Unsigned 32-bit integer
        TypeInfo(0U);
        // Unsigned 64-bit integer
        TypeInfo(0UL);
        // floating point 4 bytes
        TypeInfo(0F);
        // floating point 8 bytes
        TypeInfo(0D);
        // floating point 16 bytes
        TypeInfo(0M);

        void TypeInfo(object o)
        {
            Type type = o.GetType();
            var min = type.GetField("MinValue")?.GetValue(null);
            var max = type.GetField("MaxValue")?.GetValue(null);
            Console.WriteLine($"Type[{type}] Min[{min}] Max[{max}]");
        }

        // Unicode characters
        char a = 'a';
        Rune rune = new Rune(a);
        Console.WriteLine($"{rune}");

        //Boolean
        bool boolean = true;
        Console.WriteLine($"{boolean}");

        // Enumeration Types
        foreach (Season enumValue in Enum.GetValues(enumType: typeof(Season)))
        {
            Console.WriteLine(enumValue);
        }

        // Struct Types
        var coords = new Coords(0D, 0D);
        Console.WriteLine(coords);

        // Nullable Types
        bool? flag1 = null;
        Console.WriteLine($"{flag1}");

        // Tuple Types
        (double, int) t0 = (4.5, 3);
        Console.WriteLine($"Tuple with elements {t0.Item1} and {t0.Item2}.");
        
        var t1 = (Sum: 4.5, Count: 3);
        Console.WriteLine($"Sum of {t1.Count} elements is {t1.Sum}.");

        (double Sum, int Count) d = (4.5, 3);
        Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

        var sum = 4.5;
        var count = 3;
        var t2 = (sum, count);
        Console.WriteLine($"Sum of {t2.count} elements is {t2.sum}.");
    }
}

// Enumeration Types
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

// Struct Types
// Typically, you use structure types to design small data-centric types that provide little or no behavior. (Value semantics)
// If you're focused on the behavior of a type, consider defining a class. (Reference semantics)
public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}