namespace finalProject.Api.Data
{
    public class Equipment
    {
        public string ArmorType { get; set; } = "Null";
        public int ArmorValue { get; set; }
        public string ArmorNotes { get; set; } = ". . . . .";

        public string ClothingType { get; set; } = "Null";
        public int ClothingValue { get; set; }
        public string ClothingNotes { get; set; } = ". . . . .";

        public string Weapon1Type { get; set; } = "Null";
        public string Weapon1Notes { get; set; } = ". . . . .";
        public string Weapon2Type { get; set; } = "Null";
        public string Weapon2Notes { get; set; } = ". . . . .";

        public string MiscItems { get; set; } = ". . . . .";
    }
}
