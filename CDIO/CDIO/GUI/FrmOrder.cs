using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO.GUI
{
    public partial class FrmOrder : Form
    {
        BL.Menu blMenu;
        DA.DA_Menu daMenu;
        private int Hienco;
        public FrmOrder()
        {
            InitializeComponent();
            FrmMenu f = new FrmMenu();
            blMenu = new BL.Menu(f);
            daMenu = new DA.DA_Menu();
        }

        private void flowTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            loadDish();
            loadTable();
            MessageBox.Show(listView1.Items.Count.ToString());
        }
        //load list table under button
        public void loadTable()
        {
            this.flowTable.Controls.Clear();
            int DrinksWitdh = 100;
            int DrinksHeight = 100;

            List<DA.Table> tableList = new List<DA.Table>();
            tableList = daMenu.getListTable();
            foreach (DA.Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = DrinksWitdh,
                    Height = DrinksHeight
                };
                if(daMenu.getTableBill(item.Id) ==1)
                    btn.Text = item.Id + Environment.NewLine + "In use";
                else
                    btn.Text = item.Id + Environment.NewLine + "Empty";
                //    btn.Image = global::Thefaceless.Properties.Resources.drink_2_icon;
                btn.ForeColor = Color.Black;
                //bắt sự kiện click cho các button
                btn.Click += btn_Click;
                btn.Tag = item;
                this.flowTable.Controls.Add(btn);

            }
        }

        //load list dish under button
        public void loadDish()
        {
            this.flowDish.Controls.Clear();
            int DrinksWitdh = 100;
            int DrinksHeight = 100;

            List<DA.Dish> drinkslist = new List<DA.Dish>();
            drinkslist = daMenu.getListDish();
            foreach (DA.Dish item in drinkslist)
            {
                Button btn = new Button()
                {
                    Width = DrinksWitdh,
                    Height = DrinksHeight
                };
                btn.Text = item.DishName + Environment.NewLine + "(" + item.Number + ")";
                //    btn.Image = global::Thefaceless.Properties.Resources.drink_2_icon;
                btn.ForeColor = Color.Black;
                //bắt sự kiện click cho các button
                btn.Click += btn_Click;
                btn.Tag = item;
                this.flowDish.Controls.Add(btn);

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<DA.Dish> ld = daMenu.getListDish() ;
            //lấy tên đồ uống
            string DishName = ((sender as Button).Tag as DA.Dish).DishName;
            int x;
            int sl = 0;
            //hiện form nhập số lượng
            do
            {
                FrmInput fi = new FrmInput();
                fi.ShowDialog();
                x = fi.soluong;

                foreach (DA.Dish items in ld)
                {
                    if (DishName.Equals(items.DishName))
                    {
                        Hienco = items.Number;
                        for (int i = 0; i < this.listView1.Items.Count; i++)
                        {
                            if (DishName.Equals(this.listView1.Items[i].SubItems[0].Text))
                            {
                                //lấy tổng số lượng order
                                sl = int.Parse(this.listView1.Items[i].SubItems[1].Text) + x;
                            }
                        }
                        if (x > Hienco || sl > Hienco)
                            MessageBox.Show("So luong khong du,vui long nhap lai");
                    }
                }
            } while (x > Hienco || sl > Hienco);

            if (x != 0)
            {
                Boolean isHave = false;
                //duyệt trong danh sach đồ uống để lấy Tên đồ uống,số lượng và giá tiền
                foreach (DA.Dish items in ld)
                {
                    if (DishName.Equals(items.DishName))
                    {
                        for (int i = 0; i < this.listView1.Items.Count; i++)
                            //kiểm tra xem món vừa gọi đã có trong bill chưa
                            if (DishName.Equals(this.listView1.Items[i].SubItems[0].Text))
                            {
                                isHave = true;
                                //có trong bill thì tăng số lượng + giá tiền lên
                                this.listView1.Items[i].SubItems[1].Text = (int.Parse(this.listView1.Items[i].SubItems[1].Text) + x).ToString();
                                this.lbTotal.Text = (int.Parse(this.lbTotal.Text) + x * items.Price).ToString();
                                this.listView1.Items[i].SubItems[3].Text = (int.Parse(this.listView1.Items[i].SubItems[1].Text) * items.Price).ToString();
                            }
                        //chưa có thì thêm vào bill
                        if (isHave == false)
                        {
                            ListViewItem Ten = new ListViewItem(items.DishName, 0);
                            ListViewItem.ListViewSubItem SoLuong = new ListViewItem.ListViewSubItem(Ten, x.ToString());
                            ListViewItem.ListViewSubItem Gia = new ListViewItem.ListViewSubItem(Ten, items.Price.ToString());
                            double total = x * items.Price;
                            this.lbTotal.Text = (int.Parse(lbTotal.Text) + total).ToString();
                            ListViewItem.ListViewSubItem Tong = new ListViewItem.ListViewSubItem(Ten, total.ToString());
                            Ten.SubItems.Add(SoLuong);
                            Ten.SubItems.Add(Gia);
                            Ten.SubItems.Add(Tong);
                            listView1.Items.Add(Ten);
                        }
                    }
                }
            }
        }
    }
}
