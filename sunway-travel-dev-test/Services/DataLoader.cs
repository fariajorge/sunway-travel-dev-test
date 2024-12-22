
using Newtonsoft.Json;
using Models;

namespace Services
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

                // Deserialize into a list of Hotel objects
                var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonData);
                
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