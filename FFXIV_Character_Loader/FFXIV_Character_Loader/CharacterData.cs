using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV_Character_Loader
{
    public partial class CharacterData
    {
        public object Achievements { get; set; }
        public object AchievementsPublic { get; set; }
        public Character Character { get; set; }
        public object FreeCompany { get; set; }
        public object FreeCompanyMembers { get; set; }
        public object Friends { get; set; }
        public object FriendsPublic { get; set; }
        public object PvPTeam { get; set; }
    }

    public partial class Character
    {
        public ClassJob ActiveClassJob { get; set; }
        public Uri Avatar { get; set; }
        public string Bio { get; set; }
        public ClassJob[] ClassJobs { get; set; }
        public string Dc { get; set; }
        public string FreeCompanyId { get; set; }
        public GearSet GearSet { get; set; }
        public long Gender { get; set; }
        public GrandCompany GrandCompany { get; set; }
        public long GuardianDeity { get; set; }
        public long Id { get; set; }
        public object[] Minions { get; set; }
        public object[] Mounts { get; set; }
        public string Name { get; set; }
        public string Nameday { get; set; }
        public long ParseDate { get; set; }
        public Uri Portrait { get; set; }
        public object PvPTeamId { get; set; }
        public long Race { get; set; }
        public string Server { get; set; }
        public long Title { get; set; }
        public bool TitleTop { get; set; }
        public long Town { get; set; }
        public long Tribe { get; set; }
    }

    public partial class ClassJob
    {
        public long ClassId { get; set; }
        public long ExpLevel { get; set; }
        public long ExpLevelMax { get; set; }
        public long ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public long JobId { get; set; }
        public long Level { get; set; }
        public string Name { get; set; }
    }

    public partial class GearSet
    {
        public Dictionary<string, long> Attributes { get; set; }
        public long ClassId { get; set; }
        public Dictionary<string, Gear> Gear { get; set; }
        public string GearKey { get; set; }
        public long JobId { get; set; }
        public long Level { get; set; }
    }

    public partial class Gear
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public long Id { get; set; }
        public object[] Materia { get; set; }
        public object Mirage { get; set; }
    }

    public partial class GrandCompany
    {
        public long NameId { get; set; }
        public long RankId { get; set; }
    }

}
