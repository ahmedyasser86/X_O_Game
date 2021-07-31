using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            pnl_Home.Hide();
            TheGame t = new TheGame() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            pnl_Holder.Controls.Add(t);
            t.Show();
        }
    }
}
