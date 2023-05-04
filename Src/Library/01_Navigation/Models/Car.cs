namespace Library._01_Navigation.Models
{

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