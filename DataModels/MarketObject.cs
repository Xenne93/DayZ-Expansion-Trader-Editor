using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpansionTrader_Editor.DataModels
{

    [Serializable]
    public class MarketObject
    {
        public string ClassName { get; set; }
        public int MaxPriceThreshold { get; set; }
        public int MinPriceThreshold { get; set; }
        public double SellPricePercent { get; set; }
        public int MaxStockThreshold { get; set; }
        public int MinStockThreshold { get; set; }
        public int QuantityPercent { get; set; }
        public List<string> SpawnAttachments { get; set; }
        public List<string> Variants { get; set; }

    }
}
