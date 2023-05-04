using Library._01_Navigation.Interfaces;

namespace Library._01_Navigation.Models
{
    public abstract class VehicleBase : IVehicle
    {
        protected VehicleBase (int seats, int maximumVelocity)
        {
            this.Seats = seats;
            this.MaximumVelocity = maximumVelocity;
        }

        public Position Position { get; set; }

        public int Seats { get; }

        public int MaximumVelocity { get; }

        public abstract void Move (int xOffset, int yOffset);

        public void Move (Position offset)
        {
            this.Move(offset.X, offset.Y);
        }
    }
}
