using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace ARCHON_SYSTEM.Archon_Library
{
    public class dbLibrary
    {
        public static SQLiteConnection archDBCONN;
        public static SQLiteCommand archDBCommand;
        public static SQLiteDataAdapter archDBAdapter;
        public static DataTable archDBTable;

        public static String[] connException;


        public bool dbCONNECT(String stDataSource, String stDataBaseVer)
        {
            String myDBConnString = @"Data Source=" + stDataSource + "; Version=" + stDataBaseVer + " ;";

            try
            {
                archDBCONN = new SQLiteConnection(myDBConnString);
                archDBCONN.Open();

                return true;
            }
            catch(Exception conError)
            {
                connException[0] = conError.Message;
                return false;
            }
        }

        public static DataTable PROCESS_LIST(String strQuery)
        {
            DataTable PL_DataTable = new DataTable();
            SQLiteCommand PL_Command = new SQLiteCommand(strQuery, archDBCONN);
            SQLiteDataAdapter PL_DataAdapter = new SQLiteDataAdapter(PL_Command);
            PL_DataAdapter.Fill(PL_DataTable);

            return PL_DataTable;
        }


        public bool dbArchonQuerry(String strQuery, String strActionType)
        {
            if(strActionType == "LOGIN")
            {
                archDBCommand = new SQLiteCommand(strQuery, archDBCONN);
                archDBAdapter = new SQLiteDataAdapter(archDBCommand);
                archDBTable = new DataTable();
                archDBAdapter.Fill(archDBTable);

                if (archDBTable.Rows.Count > 0)
                {
                    archLibrary.activeUserID = archDBTable.Rows[0]["fdID"].ToString();
                    archLibrary.activeUserName = archDBTable.Rows[0]["fdUserName"].ToString();
                    archLibrary.activeFullName = archDBTable.Rows[0]["fdFullName"].ToString();
                    archLibrary.activeDepartment = archDBTable.Rows[0]["fdDepartment"].ToString();
                    archLibrary.activeUserType = archDBTable.Rows[0]["fdUserType"].ToString();
                    archLibrary.activeDateReg = archDBTable.Rows[0]["fdDateReg"].ToString();
                    archLibrary.activePWordEXP = archDBTable.Rows[0]["fdPasswordExp"].ToString();
                    archLibrary.activePassword = archDBTable.Rows[0]["fdPassword"].ToString();
                    archLibrary.activeStatus = archDBTable.Rows[0]["fdStatus"].ToString();
                    archLibrary.activeUserACC01 = archDBTable.Rows[0]["fdACC01"].ToString();
                    archLibrary.activeUserACC02 = archDBTable.Rows[0]["fdACC02"].ToString();
                    archLibrary.activeUserACC03 = archDBTable.Rows[0]["fdACC03"].ToString();
                    archLibrary.activeUserACC04 = archDBTable.Rows[0]["fdACC04"].ToString();
                    archLibrary.activeUserACC05 = archDBTable.Rows[0]["fdACC05"].ToString();
                    archLibrary.activeUserACC06 = archDBTable.Rows[0]["fdACC06"].ToString();
                    archLibrary.activeUserACC07 = archDBTable.Rows[0]["fdACC07"].ToString();
                    archLibrary.activeUserACC08 = archDBTable.Rows[0]["fdACC08"].ToString();
                    archLibrary.activeUserACC09 = archDBTable.Rows[0]["fdACC09"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                archDBCommand = new SQLiteCommand(strQuery, archDBCONN);
                archDBAdapter = new SQLiteDataAdapter(archDBCommand);
                archDBTable = new DataTable();
                archDBAdapter.Fill(archDBTable);

                if (archDBTable.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool dbArchonCRUDQuerry(            
            String qryACTION,
            String strID,
            String strUserName,
            String strFullName,
            String strDepartment,
            String strUserType,
            String strDateRegistered,
            int strPasswordStat,
            String strPassword,
            String strUserStatus,
            String strRemarks,
            String strG1_V,
            String strG1_A,
            String strG1_E,
            String strG1_D,
            String strG2_V,
            String strG2_A,
            String strG2_E,
            String strG2_D,
            String strG3_V,
            String strG3_A,
            String strG3_E,
            String strG3_D,
            String strG4_V,
            String strG4_U,
            String strG5_V,
            String strG5_P,
            String strG5_U,
            String strG6_V,
            String strG6_C,
            String strG7_V,
            String strG8_V,
            String strG8_U,
            String strG9_V,
            String strG9_A,
            String strG9_E,
            String strG9_D
            )
        {

            String strArchonQuerry;


            if (qryACTION=="UPDATE")
            {
                strArchonQuerry = @"UPDATE tblUsers " +
                                                "SET " +
                                                            "fdUserName = '" + strUserName + "', " +
                                                            "fdFullName = '" + strFullName + "', " +
                                                            "fdDepartment = '" + strDepartment + "', " +
                                                            "fdUserType = '" + strUserType + "', " +
                                                            "fdDateReg = '" + strDateRegistered + "', " +
                                                            "fdPasswordExp = '" + strPasswordStat + "', " +
                                                            "fdPassword = '" + strPassword + "', " +
                                                            "fdStatus = '" + strUserStatus + "', " +
                                                            "fdRemarks = '" + strRemarks + "', " +
                                                            "fdACC01 = '" + strG1_V + strG1_A + strG1_E + strG1_D + "', " +
                                                            "fdACC02 = '" + strG2_V + strG2_A + strG2_E + strG2_D + "', " +
                                                            "fdACC03 = '" + strG3_V + strG3_A + strG3_E + strG3_D + "', " +
                                                            "fdACC04 = '" + strG4_V + strG4_U + "', " +
                                                            "fdACC05 = '" + strG5_V + strG5_P + strG5_U + "', " +
                                                            "fdACC06 = '" + strG6_V + strG6_C + "', " +
                                                            "fdACC07 = '" + strG7_V + "', " +
                                                            "fdACC08 = '" + strG8_V + strG8_U + "', " +
                                                            "fdACC09 = '" + strG9_V + strG9_A + strG9_E + strG9_D + "' " +
                                                            "WHERE fdID LIKE '" + strID + "';";
            }
            else
            {
                strArchonQuerry = @"INSERT INTO tblUSERS " +
                                                "(" +
                                                            "fdID, " +
                                                            "fdUserName, " +
                                                            "fdFullName, " +
                                                            "fdDepartment, " +
                                                            "fdUserType, " +
                                                            "fdDateReg, " +
                                                            "fdPasswordExp, " +
                                                            "fdPassword, " +
                                                            "fdStatus, " +
                                                            "fdRemarks, " +
                                                            "fdACC01, " +
                                                            "fdACC02, " +
                                                            "fdACC03, " +
                                                            "fdACC04, " +
                                                            "fdACC05, " +
                                                            "fdACC06, " +
                                                            "fdACC07, " +
                                                            "fdACC08, " +
                                                            "fdACC09" +
                                                ") " +
                                                            "VALUES " +
                                                "(" +
                                                            "'" + strID + "', " +
                                                            "'" + strUserName + "', " +
                                                            "'" + strFullName + "', " +
                                                            "'" + strDepartment + "', " +
                                                            "'" + strUserType + "', " +
                                                            "'" + strDateRegistered + "', " +
                                                            "'" + strPasswordStat.ToString() + "', " +
                                                            "'" + strPassword + "', " +
                                                            "'" + strUserStatus + "', " +
                                                            "'" + strRemarks + "', " +
                                                            "'" + strG1_V + strG1_A + strG1_E + strG1_D + "', " +
                                                            "'" + strG2_V + strG2_A + strG2_E + strG2_D + "', " +
                                                            "'" + strG3_V + strG3_A + strG3_E + strG3_D + "', " +
                                                            "'" + strG4_V + strG4_U + "', " +
                                                            "'" + strG5_V + strG5_P + strG5_U + "', " +
                                                            "'" + strG6_V + strG6_C + "', " +
                                                            "'" + strG7_V + "', " +
                                                            "'" + strG8_V + strG8_U + "', " +
                                                            "'" + strG9_V + strG9_A + strG9_E + strG9_D + "'" +
                                                ");";
            }

            try
            {
                using(archDBCommand = new SQLiteCommand(strArchonQuerry,archDBCONN))
                {
                    int archRows = archDBCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch(Exception Err)
            {
                return false;
            }            
        }
    }
}
