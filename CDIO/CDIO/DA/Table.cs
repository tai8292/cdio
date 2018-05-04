using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class Table
    {
        string id;

        public Table(DataRow row)
        {
            id = (string)row[0];
        }

        /*public string Id { get => id; set => id = value; }*/
    }
}
