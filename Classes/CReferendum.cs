using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Article75
{
    public class CReferendum
    {
        private string _ID;
        private string _Esito;
        private int _Si;
        private int _No;
        private int _Risultato;

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }

        }

        public string Esito
        {
            get { return _Esito; }
            set { _Esito = value; }
        }

        public int SI
        {
            get { return _Si; }
            set { _Si = value; }
        }

        public int NO
        {
            get { return _No; }
            set { _No = value; }
        }

        public int Risultato
        {
            get { return _Risultato; }
            set { _Risultato = value; }
        }

        public CReferendum()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        public void ReadReferendum(Label ID1, Label Titolo1, Label Desc1, Label ID2, Label Titolo2, Label Desc2, Label ID3, Label Titolo3, Label Desc3)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();
                int conta = 0;
                //SELECT * FROM Referendum WHERE Outcome <> 'Repealed' Order by Result DESC
                string stringa = "SELECT * FROM Referendum WHERE Esito <> 'Abrogato' Order by Risultato DESC";

                OleDbCommand cmd = new OleDbCommand(stringa, conn);
                OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    conta++;

                    switch (conta)
                    {
                        case 1:
                            ID1.Text = dr.GetValue(0).ToString();
                            Titolo1.Text = dr.GetValue(1).ToString();
                            Desc1.Text = dr.GetValue(2).ToString();
                            break;
                        case 2:
                            ID2.Text = dr.GetValue(0).ToString();
                            Titolo2.Text = dr.GetValue(1).ToString();
                            Desc2.Text = dr.GetValue(2).ToString();
                            break;
                        case 3:
                            ID3.Text = dr.GetValue(0).ToString();
                            Titolo3.Text = dr.GetValue(1).ToString();
                            Desc3.Text = dr.GetValue(2).ToString();
                            break;
                        default:
                            return;
                    }
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

        public string DammiNomeReferendum(string ID)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();
                string referendum = string.Empty;
                string query = "SELECT * FROM Referendum WHERE ID =@IDRef ";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;
                OleDbParameter IDR = new OleDbParameter();
                IDR = cmdE.Parameters.Add("IDRef", OleDbType.Char);
                IDR.Value = ID;
                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    referendum = dr.GetValue(1).ToString();
                    dr.Close();
                    conn.Close();
                    return referendum;
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    return "";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                conn.Close();
            }
        }

        public void ConteggiaReferendum()
        {
            List<int> ReferendumID = new List<int>(5);

            /*
            // non ho la flessibilità
            int[] Indice;
            Indice = new int[5] ;

            // oppure in forma abbreviata
            int[] Ind = new int[5];
            */

            OleDbDataAdapter daIDRef;
            int IndiceIDRef = 0;

            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                string query = null;

                query = "SELECT ID FROM Referendum WHERE Esito <> 'Abrogato'";

                conn.Open();

                daIDRef = new OleDbDataAdapter(query, strConn);
                DataSet ds = new DataSet();
                daIDRef.Fill(ds, "ReferendumIDTable");

                foreach (DataRow row in ds.Tables["ReferendumIDTable"].Rows)
                {
                    ReferendumID.Add(int.Parse(row[0].ToString()));

                    IndiceIDRef++;
                }

                IndiceIDRef--;
                ds.Dispose();
                daIDRef.Dispose();
                conn.Close();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter daIDRefUte = new OleDbDataAdapter();
                DataSet dsUte = new DataSet();
                OleDbCommand cmdRefe = new OleDbCommand("UpdateReferendum", conn);
                cmdRefe.CommandType = System.Data.CommandType.StoredProcedure;

                while (IndiceIDRef != -1)
                {
                    _Si = 0;
                    _No = 0;

                    query = "SELECT * FROM ReferendumUtenti WHERE IDReferendum = @IDRef";

                    conn.Open();

                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    OleDbParameter IDR = new OleDbParameter();
                    IDR = cmd.Parameters.Add("IDRef", OleDbType.Char);
                    IDR.Value = ReferendumID[IndiceIDRef].ToString();
                    daIDRefUte.SelectCommand = cmd;

                    daIDRefUte.Fill(dsUte, "ReferendumIDUte");

                    foreach (DataRow row in dsUte.Tables["ReferendumIDUte"].Rows)
                    {
                        if (row[3].ToString() == "SI")
                            _Si++;
                        else
                            _No++;
                    }

                    cmd.Parameters.Clear();
                    dsUte.Clear();
                    conn.Close();

                    _Risultato = _Si - _No;

                    conn.Open();

                    cmdRefe.Parameters.Clear();
                    cmdRefe.Parameters.Add("SI", OleDbType.Integer).Value = _Si;
                    cmdRefe.Parameters.Add("NO", OleDbType.Integer).Value = _No;
                    cmdRefe.Parameters.Add("Risultato", OleDbType.Integer).Value = _Risultato;
                    cmdRefe.Parameters.Add("ID", OleDbType.Integer).Value = int.Parse(ReferendumID[IndiceIDRef].ToString());

                    cmdRefe.ExecuteNonQuery();

                    IndiceIDRef--;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static string GetReferendumByEmailAndId(string email,string id) {
            string uid = CUtente.GetUserByEmail(email).IDUTE;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();
                string stringa = "SELECT * FROM ReferendumUtenti WHERE IDUtente="+uid+" and IDReferendum="+id;
                OleDbCommand cmd = new OleDbCommand(stringa, conn);
                OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.Read())
                {
                    string res =  dr.GetValue(3).ToString();
                    dr.Close();
                    conn.Close();
                    return res;
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    return "";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return "";
        }
    }
}