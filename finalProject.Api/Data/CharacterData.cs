namespace finalProject.Api.Data
{
    public abstract class CharacterData
    {
        public string Name { get; set; } = null!;
        public string Culture { get; set; } = null!;
        public string Religion { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string FatherClass { get; set; } = null!;
        public int ChildNumber { get; set; }
        public string CurrentClass { get; set; } = null!;
        public int Age { get; set; }
        public int YearBorn { get; set; }
    }
}
