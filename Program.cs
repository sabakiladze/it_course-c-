using System.IO;
namespace N8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> cars = new List<Car>();
            string[] lines = File.ReadAllLines("CarsData.txt");
            
            foreach(string line in lines)
            {
                string[] parts=line.Split(',');
                Car car= new Car(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2]),
                    decimal.Parse(parts[3]),
                    parts[4]
                    );
                cars.Add(car);
            }
        }
    }
}
