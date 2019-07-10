using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TxtTesting
{
    public class ItemStats 
    {
        public int Slots { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; }
        public int Luk { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Att { get; set; }
        public int Matt { get; set; }
        public int Acc { get; set; }
        public int Upgrades { get; set; }
        public int ItemId { get; set; }

        public override bool Equals(object obj)
        {
            foreach(PropertyInfo propertyInfo in obj.GetType().GetProperties())
            {
               object firstValue = propertyInfo.GetValue(this, null);
               object secondValue = propertyInfo.GetValue(obj, null);

                if (!object.Equals(firstValue, secondValue))
                    return false;
            }

            return true;
        }
    }
}
