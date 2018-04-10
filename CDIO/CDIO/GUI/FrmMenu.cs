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
    public partial class FrmMenu : Form
    {
        BL.Menu menu;
        public FrmMenu()
        {
            InitializeComponent();
            menu = new BL.Menu(this);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            menu.loadForm();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            menu.addDish();
        }
    }
}
