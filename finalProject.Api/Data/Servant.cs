namespace finalProject.Api.Data
{
    public class Servant
    {
        public string Title { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        public Trait Skill1 { get; set; } = null!;
        public Trait Skill2 { get; set; } = null!;
        public Trait Skill3 { get; set; } = null!;
        public Trait Skill4 { get; set; } = null!;

        public Horse Mount { get; set; }
    }
}
