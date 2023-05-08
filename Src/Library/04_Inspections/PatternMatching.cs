namespace Library._04_Inspections;

public sealed class PatternMatching
{
    // Show Quick Fixes (Alt+Enter)
    public static string DoSomething(char c)
    {
        if (c is >= 'A' && c <= 'Z')
            return "upper-case";
        else if (c is >= 'a' && c <= 'z')
            return "lower-case";
        else
            return "what case?";
    }
}