using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Article75
{
    public class Start
    {
        private int _ID;
        private DateTime _Data;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public DateTime Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        public Start()
        {
        }

        public bool ScriviData()
        {
            LeggiData();

            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {

                DateTime Dt = DateTime.Today;

                if (Dt > _Data)
                {
                    conn.Open();

                    string Query = "UPDATE Start SET Data=@DT";
                    OleDbCommand cmd = new OleDbCommand(Query, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("DT", OleDbType.Date).Value = Dt;
                    cmd.Connection = conn;
                    int records = cmd.ExecuteNonQuery();

                    if (records > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public void LeggiData()
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string stringa = "SELECT * FROM Start";
                OleDbCommand cmd = new OleDbCommand(stringa, conn);
                OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.Read())
                {
                    _Data = DateTime.Parse(dr.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}