using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepetim
{
    public class UrunModel
    {
        public int UrunId { get; set; }
        public String UrunAd { get; set; }
        public int UrunStok { get; set; }
        public int UrunBirimFiyat { get; set; }
        public int UrunKdvYuzdeOran { get; set; }
        public int UrunSatisFiyat { get; set; }
        public int UrunSubeId { get; set; }
        public int UrunKategoriId { get; set; }

    }
}
