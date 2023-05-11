using System.Text;

namespace Library._02_Editing;

internal sealed class ILViewer
{
    public static void Loop()
    {
        var list = new List<RegularStruct> { new(1), new(2), new(3), };

        foreach (var item in list)
        {
            Console.Write(item.Foo);
        }
    }

    public static string StringBuilder(int foo) =>
        new StringBuilder().Append($"Foo: {foo}").ToString();

    public static string StringInterpolation(int foo) =>
        $"Foo: {foo}";

    public static async Task<int> AsyncAwait(int foo)
    {
        return await Task.FromResult(foo);
    }

    public static Task<int> Await(int foo)
    {
        return Task.FromResult(foo);
    }

    public static void Switch()
    {
        switch (string.Empty)
        {
            case "Foo":
                Console.WriteLine("Foo");
                break;
            case "Bar":
                Console.WriteLine("Bar");
                break;
            case "FooBar":
                Console.WriteLine("FooBar");
                break;
        }
    }

    private record struct RegularStruct(int Foo);
}