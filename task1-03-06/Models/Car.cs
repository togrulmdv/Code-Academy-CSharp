namespace task1_03_06.Models
{
    public class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public float FuelCapacity;
        public float FuelFor1Km;
        public float CurrentFuel;

        public Car(string color, int year, string Brand, string Model, float FuelCapacity, float FuelFor1Km, float CurrentFuel) : base(color, year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km= FuelFor1Km;
            this.CurrentFuel = CurrentFuel;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{color}, {year}, {Brand}, {Model}, {FuelCapacity},{FuelFor1Km}, {CurrentFuel}");
        }
        public void Drive(float distance)
        {
            if ((CurrentFuel / FuelFor1Km) > distance)
            {
                Console.WriteLine( CurrentFuel - (distance / FuelFor1Km));
            }
            else
            {
                Console.WriteLine("Benzin catmir");
            }
        }
    }
}
