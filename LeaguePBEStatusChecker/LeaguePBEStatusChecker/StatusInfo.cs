using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePBEStatusChecker
{
    public partial class StatusInfo
    {
        string Name { get; set; }
        public string Slug { get; set; }
        public string[] Locales { get; set; }
        public string Hostname { get; set; }
        public string RegionTag { get; set; }
        public Service[] Services { get; set; }
    }

    public partial class Service
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Status { get; set; }
        public Incident[] Incidents { get; set; }
    }

    public partial class Incident
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public Update[] Updates { get; set; }
    }

    public partial class Update
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Severity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public object[] Translations { get; set; }
    }

}

