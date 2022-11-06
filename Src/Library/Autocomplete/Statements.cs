namespace Library.Autocomplete;

public sealed class Statements
{
    // Example: Complete Current Statement (Ctrl+Shift+Enter)
    public void Foo(int number)
    {
        // if (number > 100 /*here*/)
        // var dict = new Dictionary<int, string /*here*/>();
        // Console.WriteLine(2 /*here*/* number)
        // var foo = CreateDto(foo: 1);
    }

    private static FooDto CreateDto(int? foo = null) => new();

    private class FooDto
    {
        public int? Foo { get; set; }
    }
}