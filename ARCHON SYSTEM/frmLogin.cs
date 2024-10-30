using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ARCHON_SYSTEM
{
    public partial class frmLogin : Form
    {

        //[DefaultDllImportSearchPaths("sqlite3.dll", EntryPoint = "sqlite3_libversion")]
        Archon_Library.archContLibrary capLibrary = new Archon_Library.archContLibrary();
        Archon_Library.dbLibrary dbLibrary = new Archon_Library.dbLibrary();

        public frmLogin()
        {
            InitializeComponent();

            load_FormControll_Settings();
        }

        public void load_FormControll_Settings()
        {
            //txtPassword.PasswordChar = "⦿";

            labLogCap.Text = capLibrary.strLoginFormCap;
            labUserName.Text = capLibrary.strLogUNameCap;
            labPassword.Text = capLibrary.strLogPWordCap;
            cmdLogin.Text = capLibrary.strLogLogButCap;
            cmdCancel.Text = capLibrary.strLogLogCanCap;

            txtUserName.Clear();
            txtPassword.Clear();

            txtUserName.Focus();
        }
        public void log_User(String strUserName, String strPassword)
        {
            String seekUserData = "SELECT * FROM tblUsers WHERE fdUserName LIKE '%" + strUserName + "%' AND fdPassword LIKE '%" + strPassword + "%';";

            Boolean hasAccess = dbLibrary.dbArchonQuerry(seekUserData, "LOGIN");

            if(hasAccess == true)
            {
                this.Close();
            }
            else
            {
                DialogResult DeniedNotice = MessageBox.Show("It seems that the username or password you provided is different from our record. Your access in this system was denied. " + Environment.NewLine + "Please review your username and password.", "Invalid Username and Password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if(DeniedNotice == DialogResult.OK)
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Select();
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult exitNotice = MessageBox.Show("Canceling the login will abort this app, do you want to continue?", "Cancelling Archon Systems", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(exitNotice == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            log_User(txtUserName.Text, txtPassword.Text);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            //txtUserName.SelectedText;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                log_User(txtUserName.Text, txtPassword.Text);
            }
        }
    }
}
