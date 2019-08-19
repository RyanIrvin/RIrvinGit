using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV_Character_Loader
{
    public partial class CharacterSearchResult
    {
        public Pagination Pagination { get; set; }
        public Result[] Results { get; set; }
    }

    public partial class Pagination
    {
        public long Page { get; set; }
        public long? PageNext { get; set; }
        public object PagePrev { get; set; }
        public long PageTotal { get; set; }
        public long Results { get; set; }
        public long ResultsPerPage { get; set; }
        public long ResultsTotal { get; set; }
    }

    public partial class Result
    {
        public Uri Avatar { get; set; }
        public long FeastMatches { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public object Rank { get; set; }
        public object RankIcon { get; set; }
        public string Server { get; set; }
    }

}
