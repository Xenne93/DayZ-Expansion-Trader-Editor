using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpansionTrader_Editor.DataModels
{
    [Serializable]
    public class MarketCategory
    {
      
        public int m_Version { get; set; }
        public string DisplayNam { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public double InitStockPercent { get; set; }
        public int IsExchange { get; set; }

        public List<MarketObject> Items { get; set; }

    }
}
