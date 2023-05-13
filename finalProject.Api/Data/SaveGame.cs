namespace finalProject.Api.Data
{
    public enum Mode
    {
        QUICK = -1, //Daily patrons are always important NPCs
        NORMAL = 0, //Daily patrons are a level mix of important and throwaway NPCs
        EXTENDED = 1 //Daily patrons are most always throwaway NPCs
    }
    public enum Difficulty
    {
        EASY = -1, //Some sort of guidance/hints, maybe lesser skill checks or increased exp gen
        NORMAL = 0, //Balanced difficulty
        HARD = 1 //No signifying colors maybe? Or higher frequency of difficult choices?
    }
    public class SaveGame
    {
        public Mode GameMode { get; set; } = 0;
        public Difficulty GameDifficulty { get; set; } = 0;
        public Character Protag { get; set; } = null!;
        public Dictionary<string, int> Rapport { get; set; } = null!;
        public int DayCount { get; set; }
        public string Notes { get; set; } = null!;
    }
}
