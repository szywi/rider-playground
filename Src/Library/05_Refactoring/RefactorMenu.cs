namespace Library._05_Refactoring;

// Refactor this (Ctrl+Shift+R)
// Extract interface
public sealed class RefactorMenu
{
    public int? Foo;

    // Introduce Field (Ctrl+R+F)
    public RefactorMenu(int foo)
    {
        var bar = "";
    }

    public void DoSomething()
    {
        Console.WriteLine(Foo);
    }


}

// Move to Another File (Ctrl+Shift+R/Ctrl+R+O)
public class NewClass
{
}