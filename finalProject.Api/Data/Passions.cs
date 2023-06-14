namespace finalProject.Api.Data
{
    public class Passions
    {
        public Trait LoveDeity { get; set; } = new("Love (Deity)");
        public Trait LoyaltyLord { get; set; } = new("Loyalty (Lord)");
        public Trait LoveFamily { get; set; } = new("Love (Family)");
        public Trait Honor { get; set; } = new("Honor");
        public Trait Hospitality { get; set; } = new("Hospitality");
    }
}
