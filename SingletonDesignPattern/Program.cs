namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = Car.GetCar();
            Console.WriteLine(car1.GetHashCode());

            Car car2 = Car.GetCar();
            Console.WriteLine(car2.GetHashCode());
        }
    }
}
