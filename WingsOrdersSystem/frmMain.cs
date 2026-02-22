using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factories;
using OperationalAreas;
using Routes;
using FormsEDI;



namespace WingsOrdersSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void xwLauchFrmFactories_ButtonClick(object sender, EventArgs e)
        {
            frmFactories frm = new frmFactories("Factories");
            frm.Show();
        }

        private void xwLauchFrmOpeArea_ButtonClick(object sender, EventArgs e)
        {            
            frmOperationalAreas frm = new frmOperationalAreas("OperationalAreas");
            frm.Show();
        }

        private void xwLauchFrmRutas_ButtonClick(object sender, EventArgs e)
        {
            frmRoutes frm = new frmRoutes("Routes");
            frm.Show();
        }

        private void xwLauchFrmEDI_Load(object sender, EventArgs e)
        {
           
        }

        private void xwLauchFrmEDI_Click(object sender, EventArgs e)
        {
            
        }

        private void xwLauchFrmEDI_ButtonClick(object sender, EventArgs e)
        {
            FormsEDI.Form1 form1 = new FormsEDI.Form1();
            form1.Show();
        }
    }
}
