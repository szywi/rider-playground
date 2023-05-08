namespace Library._04_Inspections;

public sealed class Simplification
{
    public static int DoSomething(string text)
    {
        if (!text.Any(x => !char.IsLetter(x))) return 1;
        return 0;
    }
}