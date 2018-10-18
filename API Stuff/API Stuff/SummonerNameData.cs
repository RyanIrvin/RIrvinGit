using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Stuff
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
}
