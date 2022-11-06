namespace Library.Navigation
{
    // Example: Goto Everything (Double-Shift)
    // Example: Assign Shortcuts to Actions (Cmd+Shift+A)
    // Example: Initial Letter Search (CryptoStreamMode) + Decompilation
    // Example: Base Symbols
    // Example: Type Hierarchy
    // Example: Goto Recent Locations (Ctrl+,)
    // Example: Goto Recent Files/Edits (Ctrl+Shift+,)
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