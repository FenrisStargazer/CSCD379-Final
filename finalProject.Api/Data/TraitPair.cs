namespace finalProject.Api.Data
{
    public class TraitPair
    {
        public string GoodTitle { get; set; } = null!;
        public int GoodValue { get; set; }
        public bool GoodCheck { get; set; }
        public bool GoodIsRel { get; set; }
        public string EvilTitle { get; set;} = null!;
        public int EvilValue { get; set; }
        public bool EvilCheck { get; set; }
        public bool EvilIsRel { get; set; }

        public TraitPair(string T1, string T2)
        {
            this.GoodTitle = T1;
            this.EvilTitle = T2;
        }
    }
}
