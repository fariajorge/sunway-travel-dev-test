namespace sunway_travel_dev_test.Models
{
    public class Hotel
    {
        public int Id { get; set; } 
        public string Name { get; set; } // Hotel name
        public string Location { get; set; } // Hotel location
        public float Rating { get; set; } // Rating 
        public string ImageUrl { get; set; } // URL of the hotel image
        public List<string> DatesOfTravel { get; set; } // Available travel dates
        public string BoardBasis { get; set; } // Meal plan 
        public List<Room> Rooms { get; set; } // List of rooms
    }

    public class Room
    {
        public string RoomType { get; set; } // Type of the room 
        public int Amount { get; set; } // Number of rooms available
    }
}