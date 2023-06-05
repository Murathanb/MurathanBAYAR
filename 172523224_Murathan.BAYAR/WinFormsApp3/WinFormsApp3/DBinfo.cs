using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;



namespace SQLite
{
    internal class DBinfo
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string column1 { get; set; }
        public string column2 { get; set; }

        public DBinfo() { }

       public  DBinfo(string C1, string C2)
        {
            column1 = C1;
            column2 = C2;



        }
    }
}
