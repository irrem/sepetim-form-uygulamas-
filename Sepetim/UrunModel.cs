using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepetim
{
    public class UrunModel
    {
        public int urunId { get; set; }
        public String urunAd { get; set; }
        public int urunStok { get; set; }
        public int urunBirimFiyat { get; set; }
        public int urunKdvYuzdeOran { get; set; }
        public int urunSatisFiyat { get; set; }
        public int subeId { get; set; }
        public int kategoriId { get; set; }

    }
}
