
namespace TestFromPowerLine
{
    public class CargoAuto : Auto
    {
        private int carryingCapacity;

        public int CarryingCapacity
        {
            get { return carryingCapacity; }
            set
            {
                if (value > 1000)
                    throw new ArgumentOutOfRangeException("Weight exceeds carrying capacity");
                else
                    carryingCapacity = value;
            }
        }
        public CargoAuto(int carryingCapacity)
        {
            CarryingCapacity = carryingCapacity;
            Type = TypeAuto.Cargo;
        }

        public override int KilometersLeft()
            => base.KilometersLeft() - CarryingCapacity / 200 * 4 / 100;
    }
}
