using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCHON_SYSTEM
{
    public partial class frmUserManager : Form
    {
        //[DefaultDllImportSearchPaths("sqlite3.dll", EntryPoint = "sqlite3_libversion")]
        Archon_Library.archContLibrary capLibrary = new Archon_Library.archContLibrary();
        Archon_Library.dbLibrary dbLibrary = new Archon_Library.dbLibrary();

        public frmUserManager()
        {
            InitializeComponent();

            FILL_COMBOS();

            //listUSER.DataSource = Archon_Library.dbLibrary.archDBTable;
            //listUSER.DisplayMember = "fdUserName";
            //listUSER.ValueMember = "fdID";
        }

        int iSelectedIndex = 0;

        String G1V = String.Empty;
        String G1A = String.Empty;
        String G1E = String.Empty;
        String G1D = String.Empty;

        String G2V = String.Empty;
        String G2A = String.Empty;
        String G2E = String.Empty;
        String G2D = String.Empty;

        String G3V = String.Empty;
        String G3A = String.Empty;
        String G3E = String.Empty;
        String G3D = String.Empty;

        String G4V = String.Empty;
        String G4U = String.Empty;

        String G5V = String.Empty;
        String G5P = String.Empty;
        String G5U = String.Empty;

        String G6V = String.Empty;
        String G6C = String.Empty;

        String G7V = String.Empty;

        String G8V = String.Empty;
        String G8U = String.Empty;

        String G9V = String.Empty;
        String G9A = String.Empty;
        String G9E = String.Empty;
        String G9D = String.Empty;

        String strACCESS01 = String.Empty;
        String strACCESS02 = String.Empty;
        String strACCESS03 = String.Empty;
        String strACCESS04 = String.Empty;
        String strACCESS05 = String.Empty;
        String strACCESS06 = String.Empty;
        String strACCESS07 = String.Empty;
        String strACCESS08 = String.Empty;
        String strACCESS09 = String.Empty;

        private void SETUP_CONTROLS(String strUserMode)
        {
            if(strUserMode == "viewSTATE")
            {
                txtUserName.Clear();
                txtUserID.Clear();
                txtFullName.Clear();
                cboDepartment.SelectedIndex = 0;
                cboUserType.SelectedIndex = 0;
                cboUserStatus.SelectedIndex = 0;


                txtDateRegistered.Text = "";
                txtPasswordStat.Text = "30";

                txtPassword.Clear();
                txtCPassword.Clear();
                txtRemarks.Clear();

                cmdADD.Enabled = true;
                cmdEDIT.Enabled = true;
                cmdDELETE.Enabled = true;

                cmdADD.Text = "ADD";
                cmdEDIT.Text = "EDIT";
                cmdDELETE.Text = "DELETE";

                txtUserName.Enabled = false;
                txtUserID.Enabled = false;
                txtFullName.Enabled = false;
                cboDepartment.Enabled = false;

                cboUserType.Enabled = false;
                txtDateRegistered.Enabled = false;
                txtPasswordStat.Enabled = false;

                txtPassword.Enabled = false;
                txtCPassword.Enabled = false;
                txtRemarks.Enabled = false;
                cboUserStatus.Enabled = false;

                if(listUSER.Items.Count > 0)
                {
                    listUSER.SelectedIndex = iSelectedIndex;
                    listUSER.Enabled = true;
                }
                else
                {
                    listUSER.Enabled = false;
                }

                G1_V.Enabled = false;
                G1_A.Enabled = false;
                G1_E.Enabled = false;
                G1_D.Enabled = false;

                G2_V.Enabled = false;
                G2_A.Enabled = false;
                G2_E.Enabled = false;
                G2_D.Enabled = false;

                G3_V.Enabled = false;
                G3_A.Enabled = false;
                G3_E.Enabled = false;
                G3_D.Enabled = false;

                G4_V.Enabled = false;
                G4_U.Enabled = false;

                G5_V.Enabled = false;
                G5_P.Enabled = false;
                G5_U.Enabled = false;

                G6_V.Enabled = false;
                G6_C.Enabled = false;

                G7_V.Enabled = false;

                G8_V.Enabled = false;
                G8_U.Enabled = false;

                G9_V.Enabled = false;
                G9_A.Enabled = false;
                G9_E.Enabled = false;
                G9_D.Enabled = false;
            }
            else
            {
                if(strUserMode == "newSTATE")
                {
                    CLEAR_CHECK();
                    CLEAR_ACCESS();

                    txtUserName.Clear();
                    txtUserID.Text = DateTime.Now.ToString("yyyymmdd-hhmmss");
                    txtFullName.Clear();
                    cboDepartment.SelectedIndex = 0;
                    cboUserType.SelectedIndex = 0;
                    cboUserStatus.SelectedIndex = 0;


                    txtDateRegistered.Text = DateTime.Now.ToString("yyyy-mm-dd");
                    txtPasswordStat.Text = "30";

                    txtPassword.Clear();
                    txtCPassword.Clear();
                    txtRemarks.Clear();

                    cmdADD.Enabled = true;
                    cmdEDIT.Enabled = false;
                    cmdDELETE.Enabled = true;

                    cmdADD.Text = "SAVE";
                    cmdEDIT.Text = "";
                    cmdDELETE.Text = "CANCEL";

                    txtUserName.Enabled = true;
                    txtUserID.Enabled = false;
                    txtFullName.Enabled = true;
                    cboDepartment.Enabled = true;

                    cboUserType.Enabled = true;
                    txtDateRegistered.Enabled = true;
                    txtPasswordStat.Enabled = false;

                    txtPassword.Enabled = true;
                    txtCPassword.Enabled = true;
                    txtRemarks.Enabled = true;
                    cboUserStatus.Enabled = true;

                    listUSER.Enabled = false;

                    G1_V.Enabled = true;
                    G1_A.Enabled = true;
                    G1_E.Enabled = true;
                    G1_D.Enabled = true;

                    G2_V.Enabled = true;
                    G2_A.Enabled = true;
                    G2_E.Enabled = true;
                    G2_D.Enabled = true;

                    G3_V.Enabled = true;
                    G3_A.Enabled = true;
                    G3_E.Enabled = true;
                    G3_D.Enabled = true;

                    G4_V.Enabled = true;
                    G4_U.Enabled = true;

                    G5_V.Enabled = true;
                    G5_P.Enabled = true;
                    G5_U.Enabled = true;

                    G6_V.Enabled = true;
                    G6_C.Enabled = true;

                    G7_V.Enabled = true;

                    G8_V.Enabled = true;
                    G8_U.Enabled = true;

                    G9_V.Enabled = true;
                    G9_A.Enabled = true;
                    G9_E.Enabled = true;
                    G9_D.Enabled = true;
                }
                else
                {
                    cmdADD.Enabled = true;
                    cmdEDIT.Enabled = false;
                    cmdDELETE.Enabled = true;

                    cmdADD.Text = "UPDATE";
                    cmdEDIT.Text = "";
                    cmdDELETE.Text = "CANCEL";

                    txtUserName.Enabled = false;
                    txtUserID.Enabled = false;
                    txtFullName.Enabled = false;
                    cboDepartment.Enabled = true;

                    cboUserType.Enabled = true;
                    txtDateRegistered.Enabled = true;
                    txtPasswordStat.Enabled = false;

                    txtPassword.Enabled = false;
                    txtCPassword.Enabled = false;
                    txtRemarks.Enabled = true;
                    cboUserStatus.Enabled = true;

                    listUSER.Enabled = false;

                    G1_V.Enabled = true;
                    G1_A.Enabled = true;
                    G1_E.Enabled = true;
                    G1_D.Enabled = true;

                    G2_V.Enabled = true;
                    G2_A.Enabled = true;
                    G2_E.Enabled = true;
                    G2_D.Enabled = true;

                    G3_V.Enabled = true;
                    G3_A.Enabled = true;
                    G3_E.Enabled = true;
                    G3_D.Enabled = true;

                    G4_V.Enabled = true;
                    G4_U.Enabled = true;

                    G5_V.Enabled = true;
                    G5_P.Enabled = true;
                    G5_U.Enabled = true;

                    G6_V.Enabled = true;
                    G6_C.Enabled = true;

                    G7_V.Enabled = true;

                    G8_V.Enabled = true;
                    G8_U.Enabled = true;

                    G9_V.Enabled = true;
                    G9_A.Enabled = true;
                    G9_E.Enabled = true;
                    G9_D.Enabled = true;
                }
            }
        }

        private void RECORD_SELECTOR(String strUID)
        {
            String userSearchQuery = "SELECT * FROM tblUsers WHERE fdID LIKE '" + strUID + "';";

            if(dbLibrary.dbArchonQuerry(userSearchQuery,"SEARCH RECORD") == true)
            {
                txtUserName.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdUserName"].ToString();
                txtUserID.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdID"].ToString();
                txtFullName.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdFullName"].ToString();
                cboDepartment.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdDepartment"].ToString();

                cboUserType.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdUserType"].ToString();
                txtDateRegistered.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdDateReg"].ToString();
                txtPasswordStat.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPasswordEXP"].ToString();

                txtPassword.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPassword"].ToString();
                txtCPassword.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPassword"].ToString();
                txtRemarks.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdRemarks"].ToString();
                cboUserStatus.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdStatus"].ToString();

                G1V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(0, 1);
                G1A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(1, 1);
                G1E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(2, 1);
                G1D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(3, 1);

                G2V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(0, 1);
                G2A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(1, 1);
                G2E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(2, 1);
                G2D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(3, 1);

                G3V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(0, 1);
                G3A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(1, 1);
                G3E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(2, 1);
                G3D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(3, 1);

                G4V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC04"].ToString().Substring(0, 1);
                G4U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC04"].ToString().Substring(1, 1);

                G5V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(0, 1);
                G5P = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(1, 1);
                G5U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(2, 1);

                G6V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC06"].ToString().Substring(0, 1);
                G6C = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC06"].ToString().Substring(1, 1);

                G7V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC07"].ToString().Substring(0, 1);

                G8V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC08"].ToString().Substring(0, 1);
                G8U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC08"].ToString().Substring(1, 1);

                G9V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(0, 1);
                G9A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(1, 1);
                G9E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(2, 1);
                G9D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(3, 1);

                strACCESS01 = G1V + G1A + G1E + G1D;
                strACCESS02 = G2V + G2A + G2E + G2D;
                strACCESS03 = G3V + G3A + G3E + G3D;
                strACCESS04 = G4V + G4U;
                strACCESS05 = G5V + G5P + G5U;
                strACCESS06 = G6V + G6C;
                strACCESS07 = G7V;
                strACCESS08 = G8V + G8U;
                strACCESS09 = G9V + G9A + G9E + G9D;

                PROCESS_CHECKS("READ");
            }
        }

        private void RECORD_UPDATER(String strUID)
        {
            String userSearchQuery = "UPDATE * FROM tblUsers WHERE fdID LIKE '" + strUID + "';";

            if (dbLibrary.dbArchonQuerry(userSearchQuery, "SEARCH RECORD") == true)
            {
                txtUserName.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdUserName"].ToString();
                txtUserID.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdID"].ToString();
                txtFullName.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdFullName"].ToString();
                cboDepartment.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdDepartment"].ToString();

                cboUserType.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdUserType"].ToString();
                txtDateRegistered.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdDateReg"].ToString();
                txtPasswordStat.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPasswordEXP"].ToString();

                txtPassword.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPassword"].ToString();
                txtCPassword.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdPassword"].ToString();
                txtRemarks.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdRemarks"].ToString();
                cboUserStatus.Text = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdStatus"].ToString();

                G1V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(0, 1);
                G1A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(1, 1);
                G1E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(2, 1);
                G1D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC01"].ToString().Substring(3, 1);

                G2V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(0, 1);
                G2A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(1, 1);
                G2E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(2, 1);
                G2D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC02"].ToString().Substring(3, 1);

                G3V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(0, 1);
                G3A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(1, 1);
                G3E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(2, 1);
                G3D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC03"].ToString().Substring(3, 1);

                G4V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC04"].ToString().Substring(0, 1);
                G4U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC04"].ToString().Substring(1, 1);

                G5V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(0, 1);
                G5P = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(1, 1);
                G5U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC05"].ToString().Substring(2, 1);

                G6V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC06"].ToString().Substring(0, 1);
                G6C = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC06"].ToString().Substring(1, 1);

                G7V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC07"].ToString().Substring(0, 1);

                G8V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC08"].ToString().Substring(0, 1);
                G8U = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC08"].ToString().Substring(1, 1);

                G9V = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(0, 1);
                G9A = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(1, 1);
                G9E = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(2, 1);
                G9D = Archon_Library.dbLibrary.archDBTable.Rows[0]["fdACC09"].ToString().Substring(3, 1);

                strACCESS01 = G1V + G1A + G1E + G1D;
                strACCESS02 = G2V + G2A + G2E + G2D;
                strACCESS03 = G3V + G3A + G3E + G3D;
                strACCESS04 = G4V + G4U;
                strACCESS05 = G5V + G5P + G5U;
                strACCESS06 = G6V + G6C;
                strACCESS07 = G7V;
                strACCESS08 = G8V + G8U;
                strACCESS09 = G9V + G9A + G9E + G9D;

                PROCESS_CHECKS("READ");
            }
        }

        private void CLEAR_ACCESS()
        {
            G1V = "N";
            G1A = "N";
            G1E = "N";
            G1D = "N";

            G2V = "N";
            G2A = "N";
            G2E = "N";
            G2D = "N";

            G3V = "N";
            G3A = "N";
            G3E = "N";
            G3D = "N";

            G4V = "N";
            G4U = "N";

            G5V = "N";
            G5P = "N";
            G5U = "N";

            G6V = "N";
            G6C = "N";

            G7V = "N";

            G8V = "N";
            G8U = "N";

            G9V = "N";
            G9A = "N";
            G9E = "N";
            G9D = "N";
        }

        private String GENERATE_IDNUMBER()
        {
            //ID = YYYY + JULIAN DATE (JJJJ) + ALPHA NUMERIC (AAAAAA) + HHMM

            return null;
        }

        private void FILL_COMBOS()
        {
            cboDepartment.Items.Clear();
            cboUserType.Items.Clear();
            cboUserStatus.Items.Clear();

            cboDepartment.Items.Add("");
            cboDepartment.Items.Add("Cannary");
            cboDepartment.Items.Add("Packaging");
            cboDepartment.Items.Add("Developer");

            cboUserType.Items.Add("");
            cboUserType.Items.Add("Guess");
            cboUserType.Items.Add("User");
            cboUserType.Items.Add("Administrator");
            cboUserType.Items.Add("Programmer");

            cboUserStatus.Items.Add("");
            cboUserStatus.Items.Add("ACTIVE");
            cboUserStatus.Items.Add("NOT-ACTIVE");

            //txtPassword.PasswordChar = '*';
            //txtCPassword.PasswordChar = '*';

            listUSER.Items.Clear();

            CLEAR_CHECK();
        }

        private void CLEAR_CHECK()
        {
                    G1_A.Checked = false;
                    G1_V.Checked = false;
                    G1_E.Checked = false;
                    G1_D.Checked = false;
                    G2_A.Checked = false;
                    G2_V.Checked = false;
                    G2_E.Checked = false;
                    G2_D.Checked = false;
                    G3_A.Checked = false;
                    G3_V.Checked = false;
                    G3_E.Checked = false;
                    G3_D.Checked = false;
                    G4_V.Checked = false;
                    G4_U.Checked = false;
                    G5_V.Checked = false;
                    G5_P.Checked = false;
                    G5_U.Checked = false;
                    G6_V.Checked = false;
                    G6_C.Checked = false;
                    G7_V.Checked = false;
                    G8_V.Checked = false;
                    G8_U.Checked = false;
                    G9_A.Checked = false;
                    G9_E.Checked = false;
                    G9_D.Checked = false;
                    G9_V.Checked = false;
        }

        private void PROCESS_CHECKS(String strACTIONS)
        {
            if(strACTIONS == "READ")
            {
                String ALL_CHECKER = 
                                        strACCESS01 +  
                                        strACCESS02 + 
                                        strACCESS03 + 
                                        strACCESS04 + 
                                        strACCESS05 + 
                                        strACCESS06 + 
                                        strACCESS07 + 
                                        strACCESS08 + 
                                        strACCESS09;

                CheckBox[] chkACCESSBOX =
                {
                    G1_A,
                    G1_V,
                    G1_E,
                    G1_D,
                    G2_A,
                    G2_V,
                    G2_E,
                    G2_D,
                    G3_A,
                    G3_V,
                    G3_E,
                    G3_D,
                    G4_V,
                    G4_U,
                    G5_V,
                    G5_P,
                    G5_U,
                    G6_V,
                    G6_C,
                    G7_V,
                    G8_V,
                    G8_U,
                    G9_A,
                    G9_E,
                    G9_D,
                    G9_V
            };

                for (int myCheck = 0; myCheck < ALL_CHECKER.Length; myCheck++)
                {
                    if (ALL_CHECKER.Substring(myCheck, 1) == "Y")
                    {
                        chkACCESSBOX[myCheck].Checked = true;
                    }
                    else
                    {
                        chkACCESSBOX[myCheck].Checked = false;
                    }
                }
                //MessageBox.Show(ALL_CHECKER);
            }
            else
            {

            }
        }

        private void PROCESS_ACCESS()
        {
            strACCESS01 = G1V + G1A + G1E + G1D;
            strACCESS02 = G2V + G2A + G2E + G2D;
            strACCESS03 = G3V + G3A + G3E + G3D;
            strACCESS04 = G4V + G4U;
            strACCESS05 = G5V + G5P + G5U;
            strACCESS06 = G6V + G6C;
            strACCESS07 = G7V;
            strACCESS08 = G8V + G8U;
            strACCESS09 = G9V + G9A + G9E + G9D;
        }

        private void cmdCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void G1_V_Clicked(object sender, EventArgs e)
        {
            if(G1_V.Checked==true)
            {
                G1V = "Y";
            }
            else
            {
                G1V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G1_A_Clicked(object sender, EventArgs e)
        {
            if (G1_A.Checked == true)
            {
                G1A = "Y";
            }
            else
            {
                G1A = "N";
            }

            PROCESS_ACCESS();
        }
        private void G1_E_Clicked(object sender, EventArgs e)
        {
            if (G1_E.Checked == true)
            {
                G1E = "Y";
            }
            else
            {
                G1E = "N";
            }

            PROCESS_ACCESS();
        }
        private void G1_D_Clicked(object sender, EventArgs e)
        {
            if (G1_D.Checked == true)
            {
                G1D = "Y";
            }
            else
            {
                G1D = "N";
            }

            PROCESS_ACCESS();
        }

        private void G2_V_Click(object sender, EventArgs e)
        {
            if (G2_V.Checked == true)
            {
                G2V = "Y";
            }
            else
            {
                G2V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G2_A_Click(object sender, EventArgs e)
        {
            if (G2_A.Checked == true)
            {
                G2A = "Y";
            }
            else
            {
                G2A = "N";
            }

            PROCESS_ACCESS();
        }
        private void G2_E_Click(object sender, EventArgs e)
        {
            if (G2_E.Checked == true)
            {
                G2E = "Y";
            }
            else
            {
                G2E = "N";
            }

            PROCESS_ACCESS();
        }
        private void G2_D_Click(object sender, EventArgs e)
        {
            if (G2_D.Checked == true)
            {
                G2D = "Y";
            }
            else
            {
                G2D = "N";
            }

            PROCESS_ACCESS();
        }

        private void G3_V_Click(object sender, EventArgs e)
        {
            if (G3_V.Checked == true)
            {
                G3V = "Y";
            }
            else
            {
                G3V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G3_A_Click(object sender, EventArgs e)
        {
            if (G3_A.Checked == true)
            {
                G3A = "Y";
            }
            else
            {
                G3A = "N";
            }

            PROCESS_ACCESS();
        }
        private void G3_E_Click(object sender, EventArgs e)
        {
            if (G3_E.Checked == true)
            {
                G3E = "Y";
            }
            else
            {
                G3E = "N";
            }

            PROCESS_ACCESS();
        }
        private void G3_D_Click(object sender, EventArgs e)
        {
            if (G3_D.Checked == true)
            {
                G3D = "Y";
            }
            else
            {
                G3D = "N";
            }

            PROCESS_ACCESS();
        }

        private void G4_V_Click(object sender, EventArgs e)
        {
            if (G4_V.Checked == true)
            {
                G4V = "Y";
            }
            else
            {
                G4V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G4_U_Click(object sender, EventArgs e)
        {
            if (G4_U.Checked == true)
            {
                G4U = "Y";
            }
            else
            {
                G4U = "N";
            }

            PROCESS_ACCESS();
        }

        private void G5_V_Click(object sender, EventArgs e)
        {
            if (G5_V.Checked == true)
            {
                G5V = "Y";
            }
            else
            {
                G5V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G5_P_Click(object sender, EventArgs e)
        {
            if (G5_P.Checked == true)
            {
                G5P = "Y";
            }
            else
            {
                G5P = "N";
            }

            PROCESS_ACCESS();
        }
        private void G5_U_Click(object sender, EventArgs e)
        {
            if (G5_U.Checked == true)
            {
                G5U = "Y";
            }
            else
            {
                G5U = "N";
            }

            PROCESS_ACCESS();
        }

        private void G6_V_Click(object sender, EventArgs e)
        {
            if (G6_V.Checked == true)
            {
                G6V = "Y";
            }
            else
            {
                G6V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G6_C_Click(object sender, EventArgs e)
        {
            if (G6_C.Checked == true)
            {
                G6C = "Y";
            }
            else
            {
                G6C = "N";
            }

            PROCESS_ACCESS();
        }

        private void G7_V_Click(object sender, EventArgs e)
        {
            if (G7_V.Checked == true)
            {
                G7V = "Y";
            }
            else
            {
                G7V = "N";
            }

            PROCESS_ACCESS();
        }

        private void G8_V_Click(object sender, EventArgs e)
        {
            if (G8_V.Checked == true)
            {
                G8V = "Y";
            }
            else
            {
                G8V = "N";
            }

            PROCESS_ACCESS();
        }

        private void G8_U_Click(object sender, EventArgs e)
        {
            if (G8_U.Checked == true)
            {
                G8U = "Y";
            }
            else
            {
                G8U = "N";
            }

            PROCESS_ACCESS();
        }

        private void G9_V_Click(object sender, EventArgs e)
        {
            if (G9_V.Checked == true)
            {
                G9V = "Y";
            }
            else
            {
                G9V = "N";
            }

            PROCESS_ACCESS();
        }
        private void G9_A_Click(object sender, EventArgs e)
        {
            if (G9_A.Checked == true)
            {
                G9A = "Y";
            }
            else
            {
                G9A = "N";
            }

            PROCESS_ACCESS();
        }
        private void G9_E_Click(object sender, EventArgs e)
        {
            if (G9_E.Checked == true)
            {
                G9E = "Y";
            }
            else
            {
                G9E = "N";
            }

            PROCESS_ACCESS();
        }
        private void G9_D_Click(object sender, EventArgs e)
        {
            if (G9_D.Checked == true)
            {
                G9D = "Y";
            }
            else
            {
                G9D = "N";
            }

            PROCESS_ACCESS();
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            SETUP_CONTROLS("viewSTATE");
            //RECORD_SELECTOR(listUSER.SelectedValue.ToString());
        }

        private void cmdADD_Click(object sender, EventArgs e)
        {
            if(cmdADD.Text=="SAVE")
            {
                Boolean Boo_SaveSuccess = 
                (dbLibrary.dbArchonCRUDQuerry(
                    "SAVE",
                    txtUserID.Text,
                    txtUserName.Text,
                    txtUserID.Text,
                    txtFullName.Text,
                    cboDepartment.Text,
                    cboUserType.Text,
                    txtDateRegistered.Text,
                    int.Parse(txtPasswordStat.Text),
                    txtPassword.Text,
                    cboUserStatus.Text,
                    txtRemarks.Text,
                    G1V,
                    G1A,
                    G1E,
                    G1D,
                    G2V,
                    G2A,
                    G2E,
                    G2D,
                    G3V,
                    G3A,
                    G3E,
                    G3D,
                    G4V,
                    G4U,
                    G5V,
                    G5P,
                    G5U,
                    G6V,
                    G6C,
                    G7V,
                    G8V,
                    G8U,
                    G9V,
                    G9A,
                    G9E,
                    G9D));

                if(Boo_SaveSuccess == true)
                {
                    MessageBox.Show("User " + txtUserName.Text + " was added succesfully!", "User was Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RECORD_SELECTOR(txtUserName.Text);
                }
                else
                {
                    MessageBox.Show("Adding user failed!", "User was not added!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if(cmdADD.Text=="UPDATE")
                {

                    SETUP_CONTROLS("viewSTATE");
                    RECORD_SELECTOR(listUSER.SelectedValue.ToString());

                }
                else
                {
                    SETUP_CONTROLS("newSTATE");
                }
            }
        }

        private void cmdEDIT_Click(object sender, EventArgs e)
        {
            SETUP_CONTROLS("editSTATE");
        }

        private void cmdDELETE_Click(object sender, EventArgs e)
        {
            if(cmdDELETE.Text == "CANCEL")
            {
                SETUP_CONTROLS("viewSTATE");
                RECORD_SELECTOR(listUSER.SelectedValue.ToString());
            }
        }

        private void listUSER_Click(object sender, EventArgs e)
        {
                      
        }

        private void listUSER_SelectedIndexChanged(object sender, EventArgs e)
        {
            iSelectedIndex = listUSER.SelectedIndex;
            RECORD_SELECTOR(listUSER.SelectedValue.ToString());
        }

        private void G1_V_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
