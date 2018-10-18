using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueReports
{
    public class SummonerNameData
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public string RevisionDate { get; set; }
        public int SummonerLevel { get; set; }
    }

    public class MatchList
    {
        public MatchInfo[] Matches { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int TotalGames { get; set; }

    }

    public class MatchInfo
    {
        public string PlatformId { get; set; }
        public long GameId { get; set; }
        public int Champion { get; set; }
        public int Queue { get; set; }
        public int Season { get; set; }
        public long Timestamp { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
    }
}
