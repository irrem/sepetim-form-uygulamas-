using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepetim
{
    public class TeslimatModel
    {
        public int teslimatId { get; set; }
        public int personelId { get; set; }
        public int siparisId { get; set; }
        public DateTime teslimatSaatiMin { get; set; }
        public DateTime teslimatSaatiMax { get; set; }
        public String teslimatDurumu { get; set; }
    }
}
