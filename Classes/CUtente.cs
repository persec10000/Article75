using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Article75
{
    public class CUtente
    {
        private string _IDUte;
        private string _TipoUtente;
        private string _Nome;
        private string _Cognome;
        private string _Indirizzo;
        private string _Cap;
        private string _Comune;
        private string _Email;
        private string _Tel;
        private string _Password;
        private bool _Responsabile;
        private bool _Volontario;
        public string _UserType { get; set; }

        public string IDUTE
        {
            get { return _IDUte; }
            set { _IDUte = value; }

        }

        public string TipoUtente
        {
            get { return _TipoUtente; }
            set { _TipoUtente = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Cognome
        {
            get { return _Cognome; }
            set { _Cognome = value; }
        }

        public string Indirizzo
        {
            get { return _Indirizzo; }
            set { _Indirizzo = value; }
        }

        public string Cap
        {
            get { return _Cap; }
            set { _Cap = value; }
        }

        public string Comune
        {
            get { return _Comune; }
            set { _Comune = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public bool Responsabile
        {
            get { return _Responsabile; }
            set { _Responsabile = value; }
        }

        public bool Volontario
        {
            get { return _Volontario; }
            set { _Volontario = value; }
        }

        public CUtente()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        /**
         * Created by Anca on 6/15/2020
         * get all members/anonimos from Utenti tables .
         * this method is for google map.
         */
        public static List<CUtente> GetAllUsers()
        {
            List<CUtente> res = new List<CUtente>();
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Utenti ";
                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;
                OleDbDataReader dr;
                CUtente u;
                dr = cmdE.ExecuteReader();
                while (dr.Read())
                {
                    u = new CUtente();
                    u._IDUte = dr.GetValue(0).ToString();
                    u._Email = dr.GetValue(3).ToString();
                    u._Nome = dr.GetValue(18).ToString();
                    u._Indirizzo = dr.GetValue(20).ToString();
                    u._Comune = dr.GetValue(2).ToString();
                    u._Cognome = dr.GetValue(19).ToString();
                    u._Responsabile = bool.Parse(dr.GetValue(9).ToString());
                    u.TipoUtente = dr.GetValue(10).ToString();
                    u._Tel = dr.GetValue(22).ToString();
                    u._Cap = dr.GetValue(21).ToString();
                    u._Volontario = bool.Parse(dr.GetValue(8).ToString());
                    u._UserType = dr.GetValue(1).ToString();
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
        public static CUtente GetUserByEmail(string email)
        {
            CUtente u=new CUtente();
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Utenti WHERE Email = '" + email + "'";
                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;
                OleDbDataReader dr;
                
                dr = cmdE.ExecuteReader();
                if (dr.Read())
                {
                    u._IDUte = dr.GetValue(0).ToString();
                    u._Email = dr.GetValue(3).ToString();
                    u._Nome = dr.GetValue(18).ToString();
                    u._Indirizzo = dr.GetValue(20).ToString();
                    u._Comune = dr.GetValue(2).ToString();
                    u._Cognome = dr.GetValue(19).ToString();
                    u._Responsabile = bool.Parse(dr.GetValue(9).ToString());
                    u.TipoUtente = dr.GetValue(10).ToString();
                    u._Tel = dr.GetValue(22).ToString();
                    u._Cap = dr.GetValue(21).ToString();
                    u._Volontario = bool.Parse(dr.GetValue(8).ToString());
                    u._UserType = dr.GetValue(1).ToString();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return u;
        }
        public void login(string email, string password)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Utenti WHERE Email = '" + email + "' AND Password = '" + password + "'";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;

                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    _IDUte = dr.GetValue(0).ToString();
                    _Email = dr.GetValue(3).ToString();
                    _Password = dr.GetValue(4).ToString();
                    dr.Close();
                    conn.Close();
                }
                else
                {
                    _Email = "";
                    _Password = "";
                    dr.Close();
                    conn.Close();
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

        public void DammiUtente(string email, int tipo)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Utenti WHERE Email = '" + email + "'";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;

                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    _IDUte = dr.GetValue(0).ToString();
                    _Comune = dr.GetValue(2).ToString();
                    _TipoUtente = dr.GetValue(1).ToString();

                    if (tipo == 1)
                        _Responsabile = dr.GetBoolean(9);
                    else if (tipo == 2)
                        _Volontario = dr.GetBoolean(8);

                    dr.Close();
                    conn.Close();
                }
                else
                {
                    _IDUte = "";
                    _Comune = "";
                    dr.Close();
                    conn.Close();
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

        private bool ControlloPassword(string vecchia)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Utenti WHERE Email = '" + _Email + "' AND Password = '" + vecchia + "'";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;

                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    return false;
                }
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

        public bool CambiaPassword(string vecchia, string nuova)
        {
            int records = 0;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            bool pass = ControlloPassword(vecchia);

            try
            {
                if (pass)
                {
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("UPDATEPassword", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("Password", OleDbType.Char).Value = nuova;
                    cmd.Parameters.Add("email", OleDbType.Char).Value = _Email;

                    records = cmd.ExecuteNonQuery();

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

        public bool CancellaReferendumUtenti(string ID)
        {
            int records = 0;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbCommand cmdDEL = new OleDbCommand("DelRefUtenti", conn);

            try
            {
                conn.Open();
                cmdDEL.CommandType = System.Data.CommandType.StoredProcedure;
                OleDbParameter codice = new OleDbParameter();
                codice = cmdDEL.Parameters.Add("@ID", OleDbType.Integer);
                codice.Value = int.Parse(ID);

                records = cmdDEL.ExecuteNonQuery();

                if (records > 0)
                    return true;
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

        public int ModificaUtente(string ID, int tipo)
        {
            int records = 0;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbCommand cmdDEL = new OleDbCommand("DelRefUtenti", conn);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmdDEL.CommandType = System.Data.CommandType.StoredProcedure;
                OleDbParameter codice = new OleDbParameter();
                codice = cmdDEL.Parameters.Add("@ID", OleDbType.Integer);
                codice.Value = int.Parse(ID);

                records = cmdDEL.ExecuteNonQuery();

                int valore = ScriviNuovoMembro(cmd, ID, tipo);
                return valore;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        private int ScriviNuovoMembro(OleDbCommand cmd, string ID, int tipo)
        {
            int records = 0;

            cmd.Parameters.Add("Utente", OleDbType.Char).Value = "Membro";
            cmd.Parameters.Add("Comune", OleDbType.Char).Value = _Comune;
            cmd.Parameters.Add("Email", OleDbType.Char).Value = _Email;
            cmd.Parameters.Add("Nome", OleDbType.Char).Value = _Nome;

            if (tipo == 1||tipo==0)
            {
                cmd.Parameters.Add("Cognome", OleDbType.Char).Value = _Cognome;
                cmd.Parameters.Add("Indirizzo", OleDbType.Char).Value = _Indirizzo;
                cmd.Parameters.Add("Cap", OleDbType.Char).Value = _Cap;
                
            }

            switch (tipo)
            {
                case 1:
                    cmd.CommandText = "ModUtenteResp";
                    cmd.Parameters.Add("Responsabile", true);//.Value = true;
                    cmd.Parameters.Add("Tel", OleDbType.Char).Value = _Tel;
                    break;

                case 2:
                    cmd.CommandText = "ModUtenteVol";
                    cmd.Parameters.Add("Volontario", OleDbType.Boolean).Value = true;
                    break;

                default:
                    cmd.CommandText = "ModUtenteAnonimo";
                    cmd.Parameters.Add("MembroAnonimo", OleDbType.Boolean).Value = true;
                    cmd.Parameters.Add("Tel", OleDbType.Char).Value = _Tel;
                    break;
            }

            cmd.Parameters.Add("ID", OleDbType.Char).Value = ID;

            records = cmd.ExecuteNonQuery();

            if (records > 0)
                return 1;
            else
                return 2;
        }

        public bool ControlloComune(string comune)
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Utenti WHERE UCASE(Comune) = '" + comune.ToUpper() + "'";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;

                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    return false;
                }
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
    }
}