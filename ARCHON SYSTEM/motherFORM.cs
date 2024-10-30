using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace ARCHON_SYSTEM
{
    public partial class motherFORM : Form
    {
        Archon_Library.archContLibrary capLibrary = new Archon_Library.archContLibrary();
        Archon_Library.dbLibrary dbaseLibrary = new Archon_Library.dbLibrary();

        Form frmLoginModule = new frmLogin();


        private int childFormNumber = 0;
        Form pageUserManager;

        public motherFORM()
        {
            InitializeComponent();
        }

        private void cmdsEXIT_Click(object sender, EventArgs e)
        {
            DialogResult exitMassage = MessageBox.Show("Are you sure you wanted to exit this program?", "Exititng Archon System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(exitMassage == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pstUserSettings_Click(object sender, EventArgs e)
        {
            pageUserManager = new frmUserManager();
            pageUserManager.MdiParent = this;
            pageUserManager.Show();
        }

        private void motherFORM_Load(object sender, EventArgs e)
        {
            Archon_Library.archLibrary.flagDBConnected = dbaseLibrary.dbCONNECT(Application.StartupPath + @"\archonDB.db", "3");
            if(Archon_Library.archLibrary.flagDBConnected == true)
            {
                frmLoginModule.ShowDialog();
            }
            else
            {
                DialogResult connectErrorMassage = MessageBox.Show("There appears to be an issue with the database connection. As a result, the system will terminate.", "Database connection problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (connectErrorMassage == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
