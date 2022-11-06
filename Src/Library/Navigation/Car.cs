namespace Library.Navigation
{
    // Different matching
    // Search by class
    // Example: Goto Everything (Ctrl-T)
    // Example: Assign Shortcuts to Actions (Cmd+Shift+A)
    // Example: Initial Letter Search (CryptoStreamMode) + Decompilation
    // Example: Base Symbols
    // Example: Type Hierarchy
    // Example: Goto Recent Locations (Ctrl+,)
    // Example: Goto Recent Files/Edits (Ctrl+Shift+,)
    // Ctrl + T (Search everywhere)
    // Ctrl + Shift + A (Action)
    // Alt+\ (Go to member in current class)
    // Navigate back/forward
    // Alt + ` (Navigate menu)
    // Find usages
    public class Car : VehicleBase
    {
        public Car(int seats, int maximumVelocity)
            : base(seats, maximumVelocity)
        {
        }

        public override void Move(int xOffset, int yOffset)
        {
            throw new NotImplementedException();
        }
    }
}