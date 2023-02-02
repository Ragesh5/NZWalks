namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double length { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkDificultyId { get; set; }

        // Navication Property
        public Region Region { get; set; }
        public WalkDificulty WalkDificulty { get; set; }

    }
}
