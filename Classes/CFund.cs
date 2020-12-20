using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Article75
{
    public class CFund
    {
        private string _IDFund;
        private string _title;
        private string _desc;
        private int _amount;
        private int _yes;
        private int _no;

        public string IDUTE
        {
            get { return _IDFund; }
            set { _IDFund = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int yes
        {
            get { return _yes; }
            set { _yes = value; }
        }
        public int no
        {
            get { return _no; }
            set { _no = value; }
        }

        public static List<CFund> GetAllFund()
        {
            List<CFund> res = new List<CFund>();
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Fund ";
                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;
                OleDbDataReader dr;
                CFund u;
                dr = cmdE.ExecuteReader();
                while (dr.Read())
                {
                    u = new CFund();
                    u._IDFund = dr.GetValue(0).ToString();
                    u._title = dr.GetValue(1).ToString();
                    u._desc = dr.GetValue(2).ToString();
                    u._amount = int.Parse( dr.GetValue(3).ToString() );
                    u._yes = int.Parse( dr.GetValue(4).ToString());
                    u._no = int.Parse( dr.GetValue(5).ToString() );
                    res.Add(u);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return res;
        }

        public int CountingFund(int IDFund, int IDUser, string SiNo)//CountingReferendum
        {
            int nRet = 0;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            string strquery;
            try
            {
                conn.Open();
                // FundUser table
                using (OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM FundUser WHERE IDUser=@IDUser AND IDFund=@IDFund", conn))
                {
                    selectCommand.Parameters.Add("@IDUser", OleDbType.Integer).Value = IDUser;
                    selectCommand.Parameters.Add("@IDFund", OleDbType.Integer).Value = IDFund;
                    OleDbDataReader drFundUser = selectCommand.ExecuteReader();
                    if(drFundUser.Read())
                    {//update
                        int nIDofFundUser = int.Parse(drFundUser.GetValue(0).ToString());
                        using (OleDbCommand updateCommand = new OleDbCommand("UPDATE FundUser SET [SiNo]=? WHERE [ID]=? ", conn))
                        {
                            updateCommand.Parameters.AddWithValue("@SiNo", SiNo);
                            updateCommand.Parameters.AddWithValue("@ID", nIDofFundUser);
                            updateCommand.ExecuteNonQuery();
                            updateCommand.Dispose();
                        }
                    }
                    else
                    {//insert
                        using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO FundUser ([IDUser],[IDFund],[SiNo]) VALUES (?,?,?)", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@IDUser", IDUser);
                            insertCommand.Parameters.AddWithValue("@IDFund", IDFund);
                            insertCommand.Parameters.AddWithValue("@SiNo", SiNo);
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Dispose();
                        }
                    }
                    selectCommand.Dispose();
                    drFundUser.Close();
                }

                // Fund table
                strquery = "SELECT * FROM Fund WHERE ID=@ID";
                OleDbCommand cmdR = new OleDbCommand();
                cmdR.CommandText = strquery;
                cmdR.Connection = conn;
                cmdR.Parameters.Add("@ID", OleDbType.Char).Value = IDFund.ToString();
                OleDbDataReader drR;
                drR = cmdR.ExecuteReader();
                if (drR.Read())
                {
                    int SI = 0;
                    int NO = 0;

                    SI = int.Parse(drR.GetValue(4).ToString());
                    NO = int.Parse(drR.GetValue(5).ToString());

                    drR.Close();
                    cmdR.Dispose();

                    if (SiNo == "SI")
                    {
                        SI = SI + 1;
                        nRet = SI;
                    }
                    else
                    {
                        NO = NO + 1;
                        nRet = NO;
                    }

                    
                    strquery = "UPDATE Fund SET [yes]=?, [no]=? WHERE [ID]=? ";
                    using (OleDbCommand updateCommand = new OleDbCommand(strquery, conn))
                    {
                        updateCommand.Parameters.AddWithValue("@yes", SI);
                        updateCommand.Parameters.AddWithValue("@no", NO);
                        updateCommand.Parameters.AddWithValue("@ID", IDFund);
                        updateCommand.ExecuteNonQuery();
                        updateCommand.Dispose();                        
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return nRet;
            }
            finally
            {
                conn.Close();
            }

            return nRet;
        }

        public static int GetYesNo(int IDFund, int IDUser)
        {
            int nYesNoNone = -1;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
                // FundUser table
                using (OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM FundUser WHERE IDUser=@IDUser AND IDFund=@IDFund", conn))
                {
                    selectCommand.Parameters.Add("@IDUser", OleDbType.Integer).Value = IDUser;
                    selectCommand.Parameters.Add("@IDFund", OleDbType.Integer).Value = IDFund;
                    OleDbDataReader drFundUser = selectCommand.ExecuteReader();
                    if (drFundUser.Read())
                    {//update
                        string strRet = drFundUser.GetValue(3).ToString();
                        nYesNoNone = (strRet == "SI") ? 1: (strRet == "NO" ? 0:-1);
                    }
                    selectCommand.Dispose();
                    drFundUser.Close();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return nYesNoNone;
            }
            finally
            {
                conn.Close();
            }

            return nYesNoNone;
        }
    }
}