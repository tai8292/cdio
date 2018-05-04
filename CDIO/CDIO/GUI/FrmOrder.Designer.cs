/*namespace CDIO.GUI
{
    partial class FrmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDish = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbTable = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameDish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowDish = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelDish.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAction);
            this.panelMain.Controls.Add(this.panelDish);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelTable);
            this.panelMain.Location = new System.Drawing.Point(18, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1087, 571);
            this.panelMain.TabIndex = 1;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.btnPay);
            this.panelAction.Controls.Add(this.btnSwitchTable);
            this.panelAction.Controls.Add(this.lbTotal);
            this.panelAction.Controls.Add(this.label1);
            this.panelAction.Location = new System.Drawing.Point(828, 464);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(256, 100);
            this.panelAction.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(154, 57);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(99, 40);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.Location = new System.Drawing.Point(7, 57);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(99, 40);
            this.btnSwitchTable.TabIndex = 3;
            this.btnSwitchTable.Text = "Switch Table";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(112, 13);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(141, 20);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total money :";
            // 
            // panelDish
            // 
            this.panelDish.Controls.Add(this.btnRemove);
            this.panelDish.Controls.Add(this.lbTable);
            this.panelDish.Controls.Add(this.listView1);
            this.panelDish.Location = new System.Drawing.Point(828, 3);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(256, 455);
            this.panelDish.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(154, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(3, 14);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(86, 25);
            this.lbTable.TabIndex = 1;
            this.lbTable.Text = "Table : ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameDish,
            this.Number,
            this.Price,
            this.Total});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 407);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NameDish
            // 
            this.NameDish.Text = "Dish Name";
            this.NameDish.Width = 67;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.flowDish);
            this.panelMenu.Location = new System.Drawing.Point(3, 285);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 283);
            this.panelMenu.TabIndex = 0;
            // 
            // flowDish
            // 
            this.flowDish.Location = new System.Drawing.Point(3, 3);
            this.flowDish.Name = "flowDish";
            this.flowDish.Size = new System.Drawing.Size(813, 276);
            this.flowDish.TabIndex = 0;
            // 
            // panelTable
            // 
            this.panelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTable.Controls.Add(this.flowTable);
            this.panelTable.Location = new System.Drawing.Point(3, 3);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(819, 276);
            this.panelTable.TabIndex = 0;
            // 
            // flowTable
            // 
            this.flowTable.Location = new System.Drawing.Point(3, 3);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(813, 270);
            this.flowTable.TabIndex = 0;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.panelMain.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelDish.ResumeLayout(false);
            this.panelDish.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Panel panelDish;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.FlowLayoutPanel flowDish;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameDish;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Button btnRemove;
    }
}*/