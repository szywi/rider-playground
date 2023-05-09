namespace Library._05_Refactoring;

public sealed class ChangeSignature
{
    private static void DoSomething() => DoSomething(true, "Foo");

    // Change signature (Ctrl+Shift+R)
    private static void DoSomething(bool foo, string bar)
    {
    }
}