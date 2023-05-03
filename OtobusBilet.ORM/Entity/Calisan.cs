using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBilet.ORM.Entity
{
    public class Calisan
    {
        public int Id { get; set; }
        public int CalisanTipID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tcno { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Cinsiyet { get; set; }
    }
}
