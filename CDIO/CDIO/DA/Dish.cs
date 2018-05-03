using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class Dish
    {
        string dishName, kindID;
        int dishID;
        int number;
        double price;
        //Image picture;
        BL.Commen commen = new BL.Commen();
        public Dish(DataRow row)
        {
            this.dishID = (int)row[0];
            this.dishName = (string)row[1];
            this.kindID = (string)row[2];
            this.number = (int)row[3];
            this.price = (double)row["p"];

            //this.picture = commen.byteToImage((byte[])row["Picture"]);
        }


        /*public string DishName { get => dishName; set => dishName = value; }
        public string KindID { get => kindID; set => kindID = value; }
        public int Number { get => number; set => number = value; }
        public double Price { get => price; set => price = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int DishID
        {
            get => dishID; set => dishID = value;

        }*/
    }
}
