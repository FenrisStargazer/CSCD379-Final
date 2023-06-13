namespace finalProject.Api.Data
{
    public class Trait
    {
        public string Title { get; set; } = null!;
        public int Value { get; set; }
        public bool Check { get; set; }
        public bool IsRel { get; set; }
        public string notes { get; set; } = null!;

        public Trait(string T1)
        {
            this.Title = T1;
        }
    }
}
