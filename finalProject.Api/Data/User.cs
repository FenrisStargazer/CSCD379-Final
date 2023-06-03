namespace finalProject.Api.Data
{
    public class User
    {
        Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string MagicWord { get; set; } = null!;
    }
}
