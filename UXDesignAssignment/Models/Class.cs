namespace UXDesignAssignment.Models
{
    public class Sauna
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Website { get; set; }
        public string Heat { get; set; } = "";
        public bool HasOpenWater { get; set; }
        public bool HasPlunge { get; set; }
        public double Rating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
