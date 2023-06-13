namespace finalProject.Api.Data
{
    public class CombatSkills
    {
        public Trait Battle { get; set; } = new("Battle");
        public Trait Horsemanship { get; set; } = new("Horsemanship");

        public Trait Dagger { get; set; } = new("Dagger");

        public Trait Sword { get; set; } = new("Sword");
        public Trait Lance { get; set; } = new("Lance");

        public Trait Axe { get; set; } = new("Axe");
        public Trait Spear { get; set; } = new("Spear");
        public Trait GreatSword { get; set; } = new("Great Sword");
        public Trait Craoiseach { get; set; } = new("Craoiseach");
        public Trait Sling { get; set; } = new("Sling");

        public Trait WriteIn1 { get; set; } = null!;
        public Trait WriteIn2 { get; set; } = null!;
        public Trait WriteIn3 { get; set; } = null!;
        public Trait WriteIn4 { get; set; } = null!;
    }
}
