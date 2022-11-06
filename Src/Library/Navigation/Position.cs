namespace Library.Navigation
{
    public readonly struct Position
    {
        public Position (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }
}
