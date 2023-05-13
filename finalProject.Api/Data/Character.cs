namespace finalProject.Api.Data
{
    public enum CharName
    {
        //
    }
    public class Character
    {
        public CharName Name { get; set; }
        public Dictionary<string, int> Stats { get; set; } = null!;
        public Dictionary<string, int> Skills { get; set; } = null!;
        public Inventory Items { get; set; } = null!;
        public int Exp { get; set; }
        public int Lvl { get; set; }
        public int ExpToLvl { get; set; }
    }
}
