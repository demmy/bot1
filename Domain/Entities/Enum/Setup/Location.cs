namespace Domain.Entities.Setup
{
    public class Location : BaseEntity
    {
        public string Title { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}