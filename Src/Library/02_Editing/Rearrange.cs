namespace Library._02_Editing;

public sealed class Rearrange
{
    // Move Element left (Ctrl+Shift+Alt+Left)
    public static void DooSomething()
    {
        try
        {
            Method(true, string.Empty);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    // Change signature (Ctrl+Shift+R)
    private static void Method(bool foo, string bar)
    {
    }
}