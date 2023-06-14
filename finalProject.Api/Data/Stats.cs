namespace finalProject.Api.Data
{
    public class Stats
    {
        public int SIZ { get; set; }
        public int DEX { get; set; }
        public int STR { get; set; }
        public int CON { get; set; }
        public int APP { get; set; }

        public int Damage { get; set; }
        public int HealingRate { get; set; }
        public int MovementRate { get; set; }
        public int TotalHitPoints { get; set; }
        public int Unconscious { get; set; }

        public int CurrentHitPoints { get; set; }
        public string Wounds { get; set; } = ". . . . .";
        public bool Chirurgery { get; set; }

        public string DistinctiveFeatures { get; set; } = ". . . . .";
        public string WomansGift { get; set; } = null!;
    }
}
