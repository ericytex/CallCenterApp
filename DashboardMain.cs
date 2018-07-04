using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoardDesign
{
    public partial class DashboardMain : Form
    {
        public DashboardMain()
        {
            InitializeComponent();
            SupportPanel.Visible = false;
            DesignStrip.Visible = true;
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupportLabel_MouseMove(object sender, MouseEventArgs e)
        {
            //update supportLabel ForeColor
            SupportLabel.ForeColor = Color.White;
            SupportLabel.BackColor = Color.LightBlue;
        }

        private void SupportLabel_MouseLeave(object sender, EventArgs e)
        {
            SupportLabel.ForeColor = Color.LightGray;
            SupportLabel.BackColor = Color.Transparent;

        }

        private void SupportLabel_MouseDown(object sender, MouseEventArgs e)
        {
            SupportLabel.BackColor = Color.Transparent;
            dashboardPanel.Visible = false;
            SupportPanel.Width = 808;
            SupportPanel.Height = 575;
            SupportPanel.Visible = true;
            SupportPanel.Dock = DockStyle.Bottom;
        }

    }
}
