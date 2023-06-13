namespace finalProject.Api.Data
{
    public class Magic
    {
        public int Insight { get; set; }
        public int MagicLimit { get; set; }
        public int LifeForce { get; set; }
        public int MagicDefense { get; set; }

        public Trait CelLore { get; set; } = new("Celestial Lore");
        public Trait GeoLore { get; set; } = new("Geomantic Lore");
        public Trait Sight { get; set; } = new("Sight");

        public Trait Talent1 { get; set; } = null!;
        public Trait Talent2 { get; set; } = null!;
        public Trait Talent3 { get; set; } = null!;
        public Trait Talent4 { get; set; } = null!;
        public Trait Talent5 { get; set; } = null!;
        public Trait Talent6 { get; set; } = null!;
        public Trait Talent7 { get; set; } = null!;
        public Trait Talent8 { get; set; } = null!;
        public Trait Talent9 { get; set; } = null!;
        public Trait Talent10 { get; set; } = null!;
    }
}
