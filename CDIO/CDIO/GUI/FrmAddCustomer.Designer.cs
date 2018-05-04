namespace CDIO.GUI
{
    partial class FrmAddCustomer
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Customer type:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(21, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 41);
            this.panel2.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(125, 7);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(232, 28);
            this.cbType.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 39);
            this.label7.TabIndex = 47;
            this.label7.Text = "Add Customer";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 10);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(20, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 41);
            this.panel4.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(126, 10);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 26);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtPhone);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(21, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(365, 41);
            this.panel7.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(126, 10);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 26);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // btnCancer
            // 
            this.btnCancer.Location = new System.Drawing.Point(299, 339);
            this.btnCancer.Name = "btnCancer";
            this.btnCancer.Size = new System.Drawing.Size(89, 36);
            this.btnCancer.TabIndex = 7;
            this.btnCancer.Text = "Cancel";
            this.btnCancer.UseVisualStyleBackColor = true;
            this.btnCancer.Click += new System.EventHandler(this.btnCancer_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtAddress);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(20, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 41);
            this.panel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 41);
            this.panel1.TabIndex = 4;
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.Location = new System.Drawing.Point(126, 7);
            this.txtPoint.MaxLength = 100;
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(232, 26);
            this.txtPoint.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point:";
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnCancer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel6);
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnCancer;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtPoint;
        public System.Windows.Forms.Label label1;
    }
}