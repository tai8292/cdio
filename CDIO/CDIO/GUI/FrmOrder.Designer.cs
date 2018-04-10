namespace CDIO.GUI
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDish = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.panelAction.Controls.Add(this.label2);
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
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "0đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.panelDish.Controls.Add(this.listView1);
            this.panelDish.Location = new System.Drawing.Point(828, 3);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(256, 455);
            this.panelDish.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 449);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelMenu
            // 
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
            this.flowTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flowTable_Paint);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.panelMain.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelDish.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}