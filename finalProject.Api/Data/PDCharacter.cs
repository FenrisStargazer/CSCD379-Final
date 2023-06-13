namespace finalProject.Api.Data
{
    public class PDCharacter
    {
        public Guid PlayerId { get; set; }
        public Guid CharacterId { get; set; }
        public CharacterData CharData;
        public Score GloryInfo { get; set; }
        public PersonalityTraits Traits { get; set; }
        public Passions Passions { get; set; }
        public Equipment CarriedEquipment { get; set; }
        public Stats Statistics { get; set; }
        public Skills Skillset { get; set; }
        public CombatSkills CombatSkillset { get; set; }
        public Magic MagicInfo { get; set; }
        public Servant Companion { get; set; }
        public Horse BestHorse { get; set; }
        public Horse ExtraHorse { get; set; } = null!;
        public ExtraInfo FamilyInfo { get; set; }
    }
}
