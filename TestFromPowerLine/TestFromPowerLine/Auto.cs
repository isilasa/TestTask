namespace TestFromPowerLine
{
    public class Auto
    {
        public TypeAuto Type { get; set; }
        public int AverageFuelConsumption { get; set; } //by 100 km
        public int Speed { get; set; }
        public int VolumeOfTheTank { get; set; }

        public virtual int KilometersLeft() => VolumeOfTheTank / AverageFuelConsumption * 100;
        public int KilometersLeft(int waight, int countOfPassenger)
            => (VolumeOfTheTank / (AverageFuelConsumption + countOfPassenger / 100 + waight / 100)) * 100;
        public int OvercomingTimeSeconds(int requiredDistance)
        {
            if (KilometersLeft() < requiredDistance)
                throw new ArgumentOutOfRangeException("The car does not have enough fuel for this distance");

            return requiredDistance / Speed;
        }
    }

    public enum TypeAuto
    {
        Passenger,
        Cargo,
        Sport
    }
}
