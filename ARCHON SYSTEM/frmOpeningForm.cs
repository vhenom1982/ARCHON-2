using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCHON_SYSTEM
{
    public partial class frmOpeningForm : Form
    {
        Int64 myThrow = 0;

        public frmOpeningForm()
        {
            InitializeComponent();
        }

        private void frmOpeningForm_Load(object sender, EventArgs e)
        {
            tickerOpening.Enabled = true;
        }

        private void tickerOpening_Tick(object sender, EventArgs e)
        {
            Form mainForm = new motherFORM();
            

            if (myThrow >= 100)
            {
                tickerOpening.Enabled = false;
                mainForm.Show();
                this.Close();
            }
            else
            {
                myThrow = myThrow + 1;
                pBAR.Value = int.Parse(myThrow.ToString());
            }
        }
    }
}
