using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV
{
     public partial class Account
    {
        public object Achievements { get; set; }
        public Character Character { get; set; }
        public object FreeCompany { get; set; }
        public object FreeCompanyMembers { get; set; }
        public object Friends { get; set; }
        public Info Info { get; set; }
        public object PvPTeam { get; set; }
    }

    public partial class Character
    {
        public ClassJob ActiveClassJob { get; set; }
        public Uri Avatar { get; set; }
        public string Bio { get; set; }
        public Dictionary<string, ClassJob> ClassJobs { get; set; }
        public string FreeCompanyId { get; set; }
        public GearSet GearSet { get; set; }
        public int Gender { get; set; }
        public GrandCompany GrandCompany { get; set; }
        public int GuardianDeity { get; set; }
        public int Id { get; set; }
        public int[] Minions { get; set; }
        public int[] Mounts { get; set; }
        public string Name { get; set; }
        public string Nameday { get; set; }
        public int ParseDate { get; set; }
        public Uri Portrait { get; set; }
        public object PvPTeamId { get; set; }
        public int Race { get; set; }
        public string Server { get; set; }
        public int Title { get; set; }
        public int Town { get; set; }
        public int Tribe { get; set; }
    }

    public partial class ClassJob
    {
        public int ClassId { get; set; }
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int JobId { get; set; }
        public int Level { get; set; }
    }

    public partial class GearSet
    {
        public Dictionary<string, int> Attributes { get; set; }
        public int ClassId { get; set; }
        public Dictionary<string, Gear> Gear { get; set; }
        public string GearKey { get; set; }
        public int JobId { get; set; }
        public int Level { get; set; }
    }

    public partial class Gear
    {
        public int? Creator { get; set; }
        public object Dye { get; set; }
        public int Id { get; set; }
        public object[] Materia { get; set; }
        public object Mirage { get; set; }
    }

    public partial class GrandCompany
    {
        public int NameId { get; set; }
        public int RankId { get; set; }
    }

    public partial class Info
    {
        public object Achievements { get; set; }
        public InfoCharacter Character { get; set; }
        public object FreeCompany { get; set; }
        public object FreeCompanyMembers { get; set; }
        public object Friends { get; set; }
        public object PvPTeam { get; set; }
    }

    public partial class InfoCharacter
    {
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public int State { get; set; }
        public int Updated { get; set; }
    }
}