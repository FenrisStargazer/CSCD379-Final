namespace finalProject.Api.Data
{
    public class PDCharacter
    {
        public Guid PlayerId { get; set; }
        public Guid CharacterId { get; set; }
        public CharacterData CharData;
        public PersonalityTraits Traits { get; set; }
        public Passions Passions { get; set; }
        public Equipment CarriedEquipment { get; set; }
        public Stats Statistics { get; set; }
    }
}
