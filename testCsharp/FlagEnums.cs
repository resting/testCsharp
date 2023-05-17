namespace testCsharp;

public class FlagEnums
{
    [Flags]
    enum BorderSides
    {
        None = 0,
        Left = 1,
        Right = 2,
        Top = 4,
        Bottom = 8
    }

    public FlagEnums()
    {
        BorderSides leftRight = BorderSides.Left | BorderSides.Right;

        if ((leftRight & BorderSides.Left) != 0)
            Console.WriteLine("- Includes Left"); // Includes Left

        string formatted = leftRight.ToString(); // "Left, Right"
        Console.WriteLine("- " + formatted);

        BorderSides s = BorderSides.Left;

        s |= BorderSides.Right;
        Console.WriteLine(s == leftRight); // True

        s ^= BorderSides.Right; // Toggles BorderSides.Right
        Console.WriteLine(s); // Left
    }
}