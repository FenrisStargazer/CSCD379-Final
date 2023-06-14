namespace finalProject.Api.Data
{
    public class ExtraInfo
    {
        //FAMILY
        public int YearWed { get; set; }
        public string SpouseName { get; set; } = "Null";
        public string Status { get; set; } = "Null";
        public string Will { get; set; } = "Null";
        public string Children { get; set; } = "Null";
        public string FamilyCharacteristic { get; set; } = "Null";

        //ANNUAL GLORY
        public int TraitGlory { get; set; }
        public int PassionGlory { get; set; }
        public int ChivalryGlory { get; set; }
        public int ReligionGlory { get; set; }
        public int HoldingGlory { get; set; }
        public int TOTALglory { get; set; }

        //HISTORY
        public string History { get; set; } = "Null";

        //SPECIAL EVENTS
        public int YearBorn { get; set; }
        public int YearEnnobled { get; set; }
        public int YearSquired { get; set; }
        public int YearLanded { get; set; }
        public int YearKnighted { get; set; }
        public int YearRoundTable { get; set; }
        public int YearDeath { get; set; }

        //HOLDINGS
        public string Holdings { get; set; } = "Null";
        public int LandGlory { get; set; }

        //EQUIPMENT AT HOME
        public int Libra { get; set; }
        public int Denarii { get; set; }
        public string HomeEquipment { get; set; } = "Null";

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
