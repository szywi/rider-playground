namespace Library.Analysis;

public sealed class PatternMatching
{
    // Example: Merge into pattern
    // Example: Convert into switch expression
    public string Foo(char c)
    {
        if (c is >= 'A' && c <= 'Z')
            return "upper-case";
        else if (c is >= 'a' && c <= 'z')
            return "lower-case";
        else
            return "what case?";
    }
}