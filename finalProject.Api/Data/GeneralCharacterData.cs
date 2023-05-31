namespace finalProject.Api.Data
{
    public class GeneralCharacterData : CharacterData
    {
        public string Name { get; set; } = null!;
        public string Homeland { get; set; } = null!;
        public string Culture { get; set; } = null!;
        public string Religion { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string FatherClass { get; set; } = null!;
        public int ChildNumber { get; set; }
        public string Lord { get; set; } = null!;
        public string CurrentClass { get; set; } = null!;
        public string CurrentHome { get; set; } = null!;
        public int Age { get; set; }
        public int YearBorn { get; set; }
    }
}
