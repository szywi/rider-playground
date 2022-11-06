namespace AnotherLibrary;

public static class LinqExtensions
{
    public static int FooSum(this IEnumerable<int> enumerable) => enumerable.Sum();
}