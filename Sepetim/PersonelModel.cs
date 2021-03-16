using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepetim
{
    public class PersonelModel
    {
        public int personelId{ get; set; }
        public String personelAd { get; set; }
        public String personelSoyad{ get; set; }
        public String personelTelefon{ get; set; }
        public String personelMail { get; set; }
        public String personelAdres { get; set; }
        public String personelIsBaslangic{ get; set; }
        public int personelKategori { get; set; }

        public int subeId { get; set; }

    }
}
