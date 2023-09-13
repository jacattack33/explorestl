namespace explorestl.Areas.Identity.Data
{
    public class UserSightFavorite
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SightId { get; set; }
    }
}
