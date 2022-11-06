namespace Library.Editing;

public enum FooEnum
{
    Foo,
    Bar,
    FooBar,
}

// Example: Add Selection for Next Occurence Alt+Shift+.
public static class MultiCaret
{
    // public static string ToDescription(this @FooEnum @enum) =>
    //     @enum switch
    //     {
    //         FooEnum.Foo => "Foo description.",
    //         FooEnum.Bar => "Bar description.",
    //         FooEnum.FooBar => "FooBar description.",
    //         _ => string.Empty,
    //     };
}