namespace finalProject.Api.Data
{
    public class ExtraInfo
    {
        //FAMILY
        public int YearWed { get; set; }
        public string SpouseName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Will { get; set; } = null!;
        public string Children { get; set; } = null!;
        public string FamilyCharacteristic { get; set; } = null!;

        //ANNUAL GLORY
        public int TraitGlory { get; set; }
        public int PassionGlory { get; set; }
        public int ChivalryGlory { get; set; }
        public int ReligionGlory { get; set; }
        public int HoldingGlory { get; set; }
        public int TOTALglory { get; set; }

        //HISTORY
        public string History { get; set; } = null!;

        //SPECIAL EVENTS
        public int YearBorn { get; set; }
        public int YearEnnobled { get; set; }
        public int YearSquired { get; set; }
        public int YearLanded { get; set; }
        public int YearKnighted { get; set; }
        public int YearRoundTable { get; set; }
        public int YearDeath { get; set; }

        //HOLDINGS
        public string Holdings { get; set; } = null!;
        public int LandGlory { get; set; }

        //EQUIPMENT AT HOME
        public int Libra { get; set; }
        public int Denarii { get; set; }
        public string HomeEquipment { get; set; } = null!;

        //ARMY
        public int OldKnights { get; set; }
        public int MidKnights { get; set; }
        public int YoungKnights { get; set; }
        public int TotalFamKnights { get; set; }
        public int VassalKnights { get; set; }
        public int LineageMen { get; set; }
        public int Levy { get; set; }
    }
}
