using Newtonsoft.Json;
using sunway_travel_dev_test.Models;

namespace sunway_travel_dev_test.Services
{
    public class DataLoader
    {
        private readonly string filePath;

        public DataLoader(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Hotel> LoadHotels()
        {
            try
            {
                // Read the JSON file
                var jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON string into a list of Hotel objects
                var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonData);

                if (hotels == null || !hotels.Any())
                {
                    throw new Exception("No hotels found in the JSON file.");
                }

                return hotels;
            }
            catch (Exception ex)
            {
                // Handle file or deserialization errors
                throw new Exception("Error loading hotel data.", ex);
            }
        }
    }
}