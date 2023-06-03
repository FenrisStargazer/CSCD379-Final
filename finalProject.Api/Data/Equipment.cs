namespace finalProject.Api.Data
{
    public class Equipment
    {
        public string ArmorType { get; set; } = null!;
        public int ArmorValue { get; set; }
        public string ArmorNotes { get; set; } = null!;

        public string ClothingType { get; set; } = null!;
        public int ClothingValue { get; set; }
        public string ClothingNotes { get; set; } = null!;

        public string Weapon1Type { get; set; } = null!;
        public string Weapon1Notes { get; set; } = null!;
        public string Weapon2Type { get; set; } = null!;
        public string Weapon2Notes { get; set; } = null!;

        public string MiscItems { get; set; } = null!;
    }
}
