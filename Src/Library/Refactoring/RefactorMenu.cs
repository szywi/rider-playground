﻿namespace Library.Refactoring;

// Refactor this
// Ctrl+Shift+R (Refactor this menu)
// Extract interface
public sealed class RefactorMenu
{
    public readonly int field;

    public string Property { get; set; }

    public RefactorMenu(int foo)
    {
    }

    public void Method(string p1, string p2)
    {
        var variable = p1;
        Console.WriteLine(variable);
    }
}