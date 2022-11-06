namespace Library.Editing;

public sealed class Simplification
{
    public int Foo(string text)
    {
        if (!text.Any(x => !char.IsLetter(x))) return 1;
        return 0;
    }
}