using finalProject.Api.Data;

namespace finalProject.Api.Data
{
    public class PersonalityTraits
    {
        public TraitPair CL { get; set; } = new TraitPair("Chaste", "Lustful");
        public TraitPair EL { get; set; } = new TraitPair("Energetic", "Lazy");
        public TraitPair FV { get; set; } = new TraitPair("Forgiving", "Vengeful");
        public TraitPair GS { get; set; } = new TraitPair("Generous", "Selfish");
        public TraitPair HD { get; set; } = new TraitPair("Honest", "Deceitful");
        public TraitPair JA { get; set; } = new TraitPair("Just", "Arbitrary");
        public TraitPair MC { get; set; } = new TraitPair("Merciful", "Cruel");
        public TraitPair MP { get; set; } = new TraitPair("Modest", "Proud");
        public TraitPair PW { get; set; } = new TraitPair("Pious", "Wordly");
        public TraitPair PR { get; set; } = new TraitPair("Prudent", "Reckless");
        public TraitPair TI { get; set; } = new TraitPair("Temperate", "Indulgent");
        public TraitPair TS { get; set; } = new TraitPair("Trusting", "Suspicious");
        public TraitPair VC { get; set; } = new TraitPair("Valorous", "Cowardly");
        public bool RelBonus { get; set; }
        public bool ChivBonus { get; set; }
    }
}
