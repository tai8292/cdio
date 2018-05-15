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
        private string tableID;
        private string billID;
        private string employeeID;
        public FrmOrder()
        {
            InitializeComponent();
            FrmMenu f = new FrmMenu();
            blMenu = new BL.Menu(f);
            daMenu = new DA.DA_Menu();
        }

        public FrmOrder(string id)
        {
            InitializeComponent();
            FrmMenu f = new FrmMenu();
            blMenu = new BL.Menu(f);
            daMenu = new DA.DA_Menu();
            this.employeeID = id;
        }
        
        public void loadForm()
        {
            loadDish();
            loadTable();
            this.listView1.Items.Clear();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            this.btnSwitchTable.Enabled = false;
            this.btnPay.Enabled = false;
            loadDish();
            loadTable();
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
                int newSize = 12;
                btn.Font = new Font(btn.Font.FontFamily, newSize);
                if (daMenu.getTableBill(item.Id) == 1)
                {
                    btn.Text = item.Id;
                    btn.Image = global::CDIO.Properties.Resources.table;
                }
                else
                {
                    btn.Text = item.Id;
                    btn.Image = global::CDIO.Properties.Resources.tableinuse;
                }
                btn.ForeColor = Color.Black;
                //bắt sự kiện click cho các button
                btn.Click += btn_ClickTable;
                btn.Tag = item;
                btn.Name = "btnTable" + item.Id;
                this.flowTable.Controls.Add(btn);

            }
        }

        public string getDishName(int id)
        {
            List<DA.Dish> listDish = daMenu.getListDish();
            for (int i = 0; i < listDish.Count; i++)
                if (id.Equals(listDish[i].DishID))
                    return listDish[i].DishName;
            return "";
        }

        private void btn_ClickTable(object sender, EventArgs e)
        {
            this.btnSwitchTable.Enabled = true;
            this.btnPay.Enabled = true;
            tableID = ((sender as Button).Tag as DA.Table).Id;
            lbTable.Text = "Table : " + tableID;
            this.listView1.Items.Clear();
            lbTotal.Text = "0";
            if (daMenu.getTableBill(tableID) == 1)
            {
                this.billID = daMenu.getBillID(tableID);
                DataTable dt = daMenu.getBillDetail(billID);
                List<DA.Dish> listDish = daMenu.getListDish();
                lbTotal.Text = "0";
                foreach (DataRow row in dt.Rows)
                {

                    ListViewItem Ten = new ListViewItem(getDishName((int)row["DishID"]), 0);
                    ListViewItem.ListViewSubItem SoLuong = new ListViewItem.ListViewSubItem(Ten, "" + (int)row["number"]);
                    ListViewItem.ListViewSubItem Gia = new ListViewItem.ListViewSubItem(Ten, "" + (double)row["Price"]);
                    double total = (int)row["number"] * (double)row["Price"];
                    this.lbTotal.Text = (int.Parse(lbTotal.Text) + total).ToString();
                    ListViewItem.ListViewSubItem Tong = new ListViewItem.ListViewSubItem(Ten, total.ToString());
                    Ten.SubItems.Add(SoLuong);
                    Ten.SubItems.Add(Gia);
                    Ten.SubItems.Add(Tong);
                    listView1.Items.Add(Ten);
                }

            }
            else
            {
                billID = null;
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
                int newSize = 12;
                btn.Font = new Font(btn.Font.FontFamily, newSize);
                btn.Text = item.DishName + Environment.NewLine + "(" + item.Number + ")";
                btn.ForeColor = Color.Black;
                //bắt sự kiện click cho các button
                btn.Click += btn_Click;
                btn.Tag = item;
                this.flowDish.Controls.Add(btn);

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tableID == null)
            {
                MessageBox.Show("Please select table first");
            }
            else
            {
                if (billID == null)
                {
                    daMenu.createBill(tableID);
                    billID = daMenu.getBillID();
                    daMenu.saveTableBill(tableID, billID);
                }
                List<DA.Dish> ld = daMenu.getListDish();
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
                                MessageBox.Show("Not enough,please input again");
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
                                    daMenu.updateBillDetail(this.billID, DishName, x, items.Price, Hienco);
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
                                daMenu.addBillDetail(this.billID, DishName, x, items.Price, Hienco);
                            }
                        }
                    }
                }
            }
            loadTable();
            loadDish();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            FrmSwitchTable f = new FrmSwitchTable(tableID);
            f.ShowDialog();
            this.loadForm();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("pay bill?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.listView1.Items.Clear();
                this.lbTotal.Text = "0";
                FrmInputCus fc = new FrmInputCus();
                fc.ShowDialog();
                daMenu.updateBill(billID,int.Parse(fc.cusID), int.Parse(employeeID));
                daMenu.deleteTableBill(billID);
                FrmBill f = new FrmBill(billID, fc.cusID, employeeID);
                f.ShowDialog();
                loadDish();
                loadTable();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listView1.SelectedIndices.Count - 1; i++)
            {
                //trừ tiền
                this.lbTotal.Text = (int.Parse(this.lbTotal.Text) - int.Parse(this.listView1.Items[this.listView1.SelectedIndices[i]].SubItems[3].Text)).ToString();
                //xóa items

                string dishID = getDishID(this.listView1.Items[this.listView1.SelectedIndices[i]].SubItems[0].Text);
                this.listView1.Items.RemoveAt(this.listView1.SelectedIndices[i]);
                daMenu.deleteBillDetail(billID, dishID);
            }
            if (this.listView1.Items.Count == 0)
            {
                daMenu.deleteTableBill(billID);
            }
            loadDish();
            loadTable();
        }

        public string getDishID(string name)
        {
            List<DA.Dish> listDish = daMenu.getListDish();
            for (int i = 0; i < listDish.Count; i++)
                if (name.Equals(listDish[i].DishName))
                    return listDish[i].DishID.ToString();
            return "";
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            FrmAddTable frm = new FrmAddTable();
            frm.ShowDialog();
            this.loadForm();
        }

        private void btnDeleteTB_Click(object sender, EventArgs e)
        {
            FrmDeleteTable frm = new FrmDeleteTable();
            frm.ShowDialog();
            this.loadForm();
        }
    }
}

