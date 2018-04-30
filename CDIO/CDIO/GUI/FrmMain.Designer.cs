namespace CDIO.GUI
{
    partial class FrmMain
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
            this.panelMenuStrip = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCustomerType = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnMenuDish = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuStrip
            // 
            this.panelMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuStrip.Controls.Add(this.btnUser);
            this.panelMenuStrip.Controls.Add(this.btnCustomerType);
            this.panelMenuStrip.Controls.Add(this.btnCustomer);
            this.panelMenuStrip.Controls.Add(this.btnPosition);
            this.panelMenuStrip.Controls.Add(this.btnEmployee);
            this.panelMenuStrip.Controls.Add(this.btnMenuDish);
            this.panelMenuStrip.Controls.Add(this.btnOrder);
            this.panelMenuStrip.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenuStrip.Location = new System.Drawing.Point(12, 12);
            this.panelMenuStrip.Name = "panelMenuStrip";
            this.panelMenuStrip.Size = new System.Drawing.Size(1133, 48);
            this.panelMenuStrip.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(809, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(83, 33);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCustomerType
            // 
            this.btnCustomerType.Location = new System.Drawing.Point(690, 6);
            this.btnCustomerType.Name = "btnCustomerType";
            this.btnCustomerType.Size = new System.Drawing.Size(83, 33);
            this.btnCustomerType.TabIndex = 5;
            this.btnCustomerType.Text = "Customer type";
            this.btnCustomerType.UseVisualStyleBackColor = true;
            this.btnCustomerType.Click += new System.EventHandler(this.btnCustomerType_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(574, 6);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(83, 33);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(457, 6);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(83, 33);
            this.btnPosition.TabIndex = 3;
            this.btnPosition.Text = "Position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(343, 6);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(83, 33);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnMenuDish
            // 
            this.btnMenuDish.Location = new System.Drawing.Point(228, 6);
            this.btnMenuDish.Name = "btnMenuDish";
            this.btnMenuDish.Size = new System.Drawing.Size(83, 33);
            this.btnMenuDish.TabIndex = 1;
            this.btnMenuDish.Text = "Menu";
            this.btnMenuDish.UseVisualStyleBackColor = true;
            this.btnMenuDish.Click += new System.EventHandler(this.btnMenuDish_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(121, 6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(83, 33);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(12, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1133, 610);
            this.panelMain.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 681);
            this.Controls.Add(this.panelMenuStrip);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuStrip;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomerType;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnMenuDish;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelMain;
    }
}