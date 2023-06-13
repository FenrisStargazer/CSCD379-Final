namespace finalProject.Api.Data
{
    public class Horse
    {
        public string Type { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool CombatTrained { get; set; }
        
        public int SIZ { get; set; }
        public int DEX { get; set; }
        public int STR { get; set; }
        public int CON { get; set; }

        public int Move { get; set; }
        public int Damage { get; set; }
        public int HealRate { get; set; }
        public int HP { get; set; }
        public int Armor { get; set; }
        public int MajorWound { get; set; }
        public int Unconcious { get; set; }
        public int Knockdown { get; set; }
    }
}
