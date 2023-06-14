namespace finalProject.Api.Data
{
    public class Servant
    {
        public string Title { get; set; } = "Null";
        public string Name { get; set; } = "Null";
        public int Age { get; set; }

        public Trait Skill1 { get; set; } = new(". . . . .");
        public Trait Skill2 { get; set; } = new(". . . . .");
        public Trait Skill3 { get; set; } = new(". . . . .");
        public Trait Skill4 { get; set; } = new(". . . . .");

        public Horse Mount { get; set; }
    }
}
