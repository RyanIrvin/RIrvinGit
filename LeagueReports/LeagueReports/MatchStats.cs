using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueReports
{
    public class MatchStats
    {
        public long GameId { get; set; }
        public string GameMode { get; set; }
        public List<TeamStats> Teams { get; set; }
        public List<Participants> Participants { get; set; }
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }
    }

    public class TeamStats
    {
        public bool FirstBlood { get; set; } //team firstblood, not player
        public int TeamId { get; set; } //100 for blue side, 200 for red side
        public string Win { get; set; } //Fail or Win
    }

    public class Participants
    {
        public ParticipantStats Stats { get; set; }
        public ParticipantTimeline Timeline { get; set; }
        public int ParticipantId { get; set; }
        public int TeamId { get; set; } //100 for blue side, 200 for redside
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
    }

    public class ParticipantTimeline
    {
        public string Lane { get; set; }
    }

    public class ParticipantIdentity
    {
        public PlayerInfo Player { get; set; }
        public int ParticipantId { get; set; }
    }

    public class ParticipantStats
    {
        public long VisionScore { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public bool FirstBloodKill { get; set; }
        public int PentaKills { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }

    }

    public class PlayerInfo
    {
        public string SummonerName { get; set; }
        public long SummonerId { get; set; }
        public long AccountId { get; set; }
        public string MatchHistoryUri { get; set; }
    }


}