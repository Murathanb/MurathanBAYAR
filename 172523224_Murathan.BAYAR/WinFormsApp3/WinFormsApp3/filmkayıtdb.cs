using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLite
{
    internal class filmlistesi
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Film_Adı { get; set; }
        public string Film_Türü { get; set; }
        public string Yönetmen { get; set; }
        public string Çıkış_Tarihi { get; set; }
        public string Fiyatı { get; set; }
        public filmlistesi() { }
        public filmlistesi(string C1, string C2,string C3,string C4,string C5)
        {
            Film_Adı = C1;
            Film_Türü = C2;
            Yönetmen = C3;
            Çıkış_Tarihi = C4;
            Fiyatı = C5;



        }
    }
}