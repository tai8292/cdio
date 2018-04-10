namespace CDIO.GUI
{
    partial class FrmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.openChoose = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtKind = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 566);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dishName,
            this.kind,
            this.number,
            this.price,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // dishName
            // 
            this.dishName.HeaderText = "Dish name";
            this.dishName.Name = "dishName";
            this.dishName.ReadOnly = true;
            this.dishName.Width = 150;
            // 
            // kind
            // 
            this.kind.HeaderText = "Kind";
            this.kind.Name = "kind";
            this.kind.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.HeaderText = "Imange";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAddDish);
            this.panel2.Location = new System.Drawing.Point(744, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 563);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 524);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 524);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.openChoose);
            this.panel8.Controls.Add(this.picture);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(3, 324);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(365, 194);
            this.panel8.TabIndex = 3;
            // 
            // openChoose
            // 
            this.openChoose.Location = new System.Drawing.Point(12, 65);
            this.openChoose.Name = "openChoose";
            this.openChoose.Size = new System.Drawing.Size(89, 36);
            this.openChoose.TabIndex = 5;
            this.openChoose.Text = "Choose";
            this.openChoose.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(126, 10);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(236, 181);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Image :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtPrice);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(3, 277);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(365, 41);
            this.panel7.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(126, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtNumber);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 41);
            this.panel6.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(126, 10);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(232, 26);
            this.txtNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtKind);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 41);
            this.panel5.TabIndex = 3;
            // 
            // txtKind
            // 
            this.txtKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKind.FormattingEnabled = true;
            this.txtKind.Location = new System.Drawing.Point(126, 7);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(232, 28);
            this.txtKind.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kind :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 41);
            this.panel4.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dish name :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 41);
            this.panel3.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(126, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 26);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dish ID :";
            // 
            // btnAddDish
            // 
            this.btnAddDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.Location = new System.Drawing.Point(200, 3);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(161, 59);
            this.btnAddDish.TabIndex = 0;
            this.btnAddDish.Text = "Add dish";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Button openChoose;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox txtKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}