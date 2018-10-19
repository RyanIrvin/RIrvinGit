using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueReports
{
    public class RankInfo
    {
        public string LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string Tier { get; set; }
        public string QueueType { get; set; }
        public string Rank { get; set; }
        public string PlayerOrTeamId { get; set; }
        public string PlayerOrTeamName { get; set; }
        public int LeaguePoints { get; set; }
        public int Wins { get; set; }
        public string Losses { get; set; }
        public bool Veteran { get; set; }
        public bool Inactive { get; set; }
        public bool FreshBlood { get; set; }
        public bool HotStreak { get; set; }
    }
}
