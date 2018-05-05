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
        Image picture;
        BL.Commen commen = new BL.Commen();

        public string DishName
        {
            get
            {
                return dishName;
            }

            set
            {
                dishName = value;
            }
        }

        public string KindID
        {
            get
            {
                return kindID;
            }

            set
            {
                kindID = value;
            }
        }
    
        public int DishID
        {
            get
            {
                return dishID;
            }

            set
            {
                dishID = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        
            set
            {
                price = value;
            }
        }

        public Image Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }

        public Dish(DataRow row)
        {
            this.DishID = (int)row[0];
            this.DishName = (string)row[1];
            this.KindID = (string)row[2];
            this.Number = (int)row[3];
            this.Price = (double)row["p"];

            //this.picture = commen.byteToImage((byte[])row["Picture"]);
        }
    }
}
