namespace finalProject.Api.Data
{
    public enum ItemType
    {
        //
    }

    public class UsableItem
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ItemType Type { get; set; }
    }
}
