using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;



namespace SQLite
{
    internal class filmkira
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string FilmAdı { get; set; }

        public filmkira() { }

        public filmkira(string C1, string C2)
        {
            KullanıcıAdı = C1;
            FilmAdı = C2;



        }
    }
}
