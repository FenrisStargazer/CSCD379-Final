using finalProject.Api.Data;

namespace finalProject.Api.Data
{
    public class PersonalityTraits
    {
        public Trait Chaste { get; set; } = new("Chaste");
        public Trait Lustful { get; set; } = new("Lustful");
        //
        public Trait Energetic { get; set; } = new("Energetic");
        public Trait Lazy { get; set; } = new("Lazy");
        //
        public Trait Forgiving { get; set; } = new("Forgiving");
        public Trait Vengeful { get; set; } = new("Vengeful");
        //
        public Trait Generous { get; set; } = new("Generous");
        public Trait Selfish { get; set; } = new("Selfish");
        //
        public Trait Honest { get; set; } = new("Honest");
        public Trait Deceitful { get; set; } = new("Deceitful");
        //
        public Trait Just { get; set; } = new("Just");
        public Trait Arbitrary { get; set; } = new("Arbitrary");
        //
        public Trait Merciful { get; set; } = new("Merciful");
        public Trait Cruel { get; set; } = new("Cruel");
        //
        public Trait Modest { get; set; } = new("Modest");
        public Trait Proud { get; set; } = new("Proud");
        //
        public Trait Pious { get; set; } = new("Pious");
        public Trait Wordly { get; set; } = new("Wordly");
        //
        public Trait Prudent { get; set; } = new("Prudent");
        public Trait Reckless { get; set; } = new("Reckless");
        //
        public Trait Temperate { get; set; } = new("Temperate");
        public Trait Indulgent { get; set; } = new("Indulgent");
        //
        public Trait Trusting { get; set; } = new("Trusting");
        public Trait Suspicious { get; set; } = new("Suspicious");
        //
        public Trait Valorous { get; set; } = new("Valorous");
        public Trait Cowardly { get; set; } = new("Cowardly");


        public bool RelBonus { get; set; }
        public bool ChivBonus { get; set; }


        public Trait DirectedOne { get; set; } = null!;
        public Trait DirectedTwo { get; set; } = null!;
        public Trait DirectedThree { get; set; } = null!;
    }
}
