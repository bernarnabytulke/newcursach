using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace newcursach
{
    public static class DataHandler
    {
        public static List<Car> LoadCars(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Car>>(json);
            }
            return new List<Car>();
        }

        public static List<Buyer> LoadBuyers(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Buyer>>(json);
            }
            return new List<Buyer>();
        }

        public static void SaveCars(List<Car> cars, string filePath)
        {
            var json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void SaveBuyers(List<Buyer> buyers, string filePath)
        {
            var json = JsonConvert.SerializeObject(buyers, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }

    //public class Car
    //{
    //    public string Brand { get; set; }
    //    public int Year { get; set; }
    //    public string Specifications { get; set; }
    //    public string Features { get; set; }
    //    public string Condition { get; set; }
    //    public decimal Price { get; set; }
    //}

    //public class Buyer
    //{
    //    public string Name { get; set; }
    //    public string ContactDetails { get; set; }
    //    public string PreferredBrands { get; set; }
    //    public string PreferredSpecifications { get; set; }
    //    public string PreferredCondition { get; set; }
    //    public decimal Budget { get; set; }
    //}
}
