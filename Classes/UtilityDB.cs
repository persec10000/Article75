using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Article75
{
    public class UtilityDB
    {
        private string _IDUte;
        private string _Comune;
        private string _Email;
        private string _Password;

        public string IDUTE
        {
            get { return _IDUte; }
            set { _IDUte = value; }

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

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public UtilityDB()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        public bool CheckEmail(string email) // Check Email
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
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public string CheckEmailToken(string token) // return "SELECT * FROM Utenti WHERE Token = '" + token + "'";
        {
            string mail = string.Empty;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Utenti WHERE Token = '" + token + "'";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;

                OleDbDataReader dr;
                dr = cmdE.ExecuteReader();

                if (dr.Read())
                {
                    mail = dr.GetValue(3).ToString();
                    dr.Close();
                    conn.Close();
                    return mail;
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

        private bool ControllaVotazioe(string IDReferendum) //Check Rating
        {
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                string query = "SELECT * FROM ReferendumUtenti WHERE IDUtente =@IDUte AND IDReferendum =@IDRef ";

                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = conn;
                cmdE.CommandText = query;
                OleDbParameter IDU = new OleDbParameter();
                IDU = cmdE.Parameters.Add("IDUte", OleDbType.Char);
                IDU.Value = _IDUte;
                OleDbParameter IDR = new OleDbParameter();
                IDR = cmdE.Parameters.Add("IDReferendum", OleDbType.Char);
                IDR.Value = IDReferendum;
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
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool CreateUser(string email, string strFirstName, string strLastName, string strComune)
        {
            bool nSuccess = false;
            CKeyGenerator Key = new CKeyGenerator();
            string Token = Key.GetUniqueKey(15, false);
            string strPassword = Key.GetUniqueKey(5, false);
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            //SendEmailConfirm("persec10000@gmail.com", "fL92P34IhAWQHDJ");
            try
            {
                int records = 0;
                bool Mail = false;
                Mail = CheckEmail(email);

                // Non ho la mail, quindi nuovo utente da registrare.
                // I don't have the email, so new user to register.

                if (!Mail)
                {
                    
                    conn.Open();
                    
                    using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO Utenti ([Utente],[Comune],[Email],[Token],[Nome],[Cognome],[Password]) VALUES (?,?,?,?,?,?,?)", conn))
                    {
                        
                        insertCommand.Parameters.AddWithValue("@Utente", "Anonimo");
                        
                        insertCommand.Parameters.AddWithValue("@Comune", strComune);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        
                        insertCommand.Parameters.AddWithValue("@Token", Token);
                        
                        insertCommand.Parameters.AddWithValue("@Nome", strFirstName);
                        
                        insertCommand.Parameters.AddWithValue("@Cognome", strLastName);
                        
                        insertCommand.Parameters.AddWithValue("@Password", strPassword);
                        
                        insertCommand.ExecuteNonQuery();
                        
                        insertCommand.Dispose();
                    }

                    /*
                    OleDbCommand cmd = new OleDbCommand("InsConferma", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("Utente", OleDbType.Char).Value = "Anonimo";
                    cmd.Parameters.Add("Email", OleDbType.Char).Value = email;
                    cmd.Parameters.Add("Token", OleDbType.Char).Value = Token;
                    cmd.Parameters.Add("Nome", OleDbType.Char).Value = strFirstName;
                    cmd.Parameters.Add("Cognome", OleDbType.Char).Value = strLastName;
                    cmd.Parameters.Add("Password", OleDbType.Char).Value = strPassword;

                    records = cmd.ExecuteNonQuery();
                    cmd.Dispose();*/
                    conn.Close();
                    //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('UtilityDB:step11.')</SCRIPT>");
                    nSuccess = CheckEmail(email);

                    if (nSuccess)
                    {
                        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('UtilityDB:Start Sending Email.')</SCRIPT>");
                        SendEmailConfirm(email, Token, strPassword);
                    }
                    else
                    {
                        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('UtilityDB:Insert User failed.')</SCRIPT>");
                    }
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('UtilityDB:duplicated email.')</SCRIPT>");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                string strout = "<SCRIPT LANGUAGE='JavaScript'>alert('UtilityDB:Exception.')</SCRIPT>";
                System.Web.HttpContext.Current.Response.Write(strout);
                strout = "<SCRIPT LANGUAGE='JavaScript'>alert(\"UtilityDB:Exception." + ex.Message + "\")</SCRIPT>";
                System.Web.HttpContext.Current.Response.Write(strout);
                return nSuccess;
            }
            finally
            {
                conn.Close();
            }
            return nSuccess;
        }


        //Write Confirm
        public int WriteConfirmReferendum(string email, string comune, string IDReferendum, string SiNo, string logato)
        {
            int ritorno = 0;
            CKeyGenerator Key = new CKeyGenerator();
            string Token = Key.GetUniqueKey(15, false);
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            
            //SendEmailConfirm("persec10000@gmail.com", "fL92P34IhAWQHDJ");
            //alert('send mail: ');
            try
            {
                int records = 0;
                bool Mail = false;
                Mail = CheckEmail(email);

                // Non ho la mail, quindi nuovo utente da registrare.
                // I don't have the email, so new user to register.

                if (!Mail)
                {
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("InsConferma", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("Utente", OleDbType.Char).Value = "Anonimo";
                    cmd.Parameters.Add("Comune", OleDbType.Char).Value = comune;
                    cmd.Parameters.Add("Email", OleDbType.Char).Value = email;
                    cmd.Parameters.Add("Token", OleDbType.Char).Value = Token;

                    records = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();

                    if (records <= 0)
                        return 1;
                    else
                        CheckEmail(email);
                }

                bool referendum = ControllaVotazioe(IDReferendum);

                //L'utente non ha mai votato per questo referendum
                // registro la votazione utente

                if (!referendum)//there is no in ReferendumUtenti
                {
                    if (logato.Equals("SI"))
                        ritorno = CountingReferendum(IDReferendum, Mail, SiNo, true);
                    else
                    {
                        if (Mail)
                            ritorno = CountingReferendum(IDReferendum, Mail, SiNo, true);
                        else//at first email
                        {
                            CUtente ute = new CUtente();
                            ute.DammiUtente(email, 0);
                            _IDUte = ute.IDUTE;
                            CountingReferendum(IDReferendum, Mail, SiNo, false);
                            SendEmailConfirm(email, Token);
                            return 0;
                        }
                    }

                    return ritorno;
                }
                else
                {
                    int idReferendum = int.Parse(IDReferendum.ToString());
                    if (logato.Equals("SI"))
                    {
                        ritorno = UpdatingReferendum(idReferendum, 0, SiNo);
                        return 2;
                    }
                    else
                    {
                        if (Mail)
                        {
                            return 4;// already created before. please login or reset password
                        }
                        else
                        {
                            return 5;// can't be happen!
                        }
                    }
                    //ritorno = UpdatingReferendum(idReferendum, 0, SiNo);
                    //return 2;// 3;//2020.1.10 
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int WriteConfirmAssociation(string email, string comune, string name, string surname, int typo)
        {
            int ritorno = 0;
            CKeyGenerator Key = new CKeyGenerator();
            string Token = Key.GetUniqueKey(15, false);
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            //SendEmailConfirm("persec10000@gmail.com", "fL92P34IhAWQHDJ");
            //alert('send mail: ');
            try
            {
                int records = 0;
                bool Mail = false;
                Mail = CheckEmail(email);

                // Non ho la mail, quindi nuovo utente da registrare.
                // I don't have the email, so new user to register.

                if (!Mail)
                {
                    conn.Open();

                    using (OleDbCommand insertCommand =
                        new OleDbCommand("INSERT INTO Utenti ([Utente],[Comune],[Email],[Token],[Nome],[Cognome],[Password],[Responsabile],[Volontario],[MembroAnonimo]) VALUES (?,?,?,?,?,?,?,?,?,?)", conn))
                    {

                        insertCommand.Parameters.AddWithValue("@Utente", "Anonimo");

                        insertCommand.Parameters.AddWithValue("@Comune", comune);
                        insertCommand.Parameters.AddWithValue("@Email", email);

                        insertCommand.Parameters.AddWithValue("@Token", Token);

                        insertCommand.Parameters.AddWithValue("@Nome", name);

                        insertCommand.Parameters.AddWithValue("@Cognome", surname);

                        insertCommand.Parameters.AddWithValue("@Password", "");
                        switch (typo)
                        {
                            case 1:
                                insertCommand.Parameters.AddWithValue("@Responsabile", true);
                                insertCommand.Parameters.AddWithValue("@Volontario", false);
                                insertCommand.Parameters.AddWithValue("@MembroAnonimo", false);
                                break;

                            case 2:
                                insertCommand.Parameters.AddWithValue("@Volontario", true);
                                insertCommand.Parameters.AddWithValue("@Responsabile", false);
                                insertCommand.Parameters.AddWithValue("@MembroAnonimo", false);
                                break;

                            default:
                                insertCommand.Parameters.AddWithValue("@MembroAnonimo", true);
                                insertCommand.Parameters.AddWithValue("@Volontario", false);
                                insertCommand.Parameters.AddWithValue("@Responsabile", false);
                                break;
                        }
                        records = insertCommand.ExecuteNonQuery();

                        insertCommand.Dispose();
                    }
                    conn.Close();

                    if (records <= 0)
                        return 1;
                    else
                        CheckEmail(email);
                }
                SendEmailConfirm(email, Token);                

                return 3;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdatingReferendum(int IDReferendum, int IDUtente, string SiNo)//UpdatingReferendum
        {
            int nRet = 0;
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);
            string strquery;
            try
            {
                conn.Open();
                using (OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM ReferendumUtenti WHERE IDUtente=@IDUtente AND IDReferendum=@IDReferendum", conn))
                {
                    selectCommand.Parameters.Add("@IDUtente", OleDbType.Integer).Value = _IDUte;
                    selectCommand.Parameters.Add("@IDReferendum", OleDbType.Integer).Value = IDReferendum;
                    OleDbDataReader drFundUser = selectCommand.ExecuteReader();
                    if (drFundUser.Read())
                    {//update
                        int nIDofFundUser = int.Parse(drFundUser.GetValue(0).ToString());
                        using (OleDbCommand updateCommand = new OleDbCommand("UPDATE ReferendumUtenti SET [SiNo]=? WHERE [ID]=? ", conn))
                        {
                            updateCommand.Parameters.AddWithValue("@SiNo", SiNo);
                            updateCommand.Parameters.AddWithValue("@ID", nIDofFundUser);
                            updateCommand.ExecuteNonQuery();
                            updateCommand.Dispose();
                        }
                    }
                    else
                    {//insert
                        using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO ReferendumUtenti ([IDUtente],[IDReferendum],[SiNo]) VALUES (?,?,?)", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@IDUtente", _IDUte);
                            insertCommand.Parameters.AddWithValue("@IDReferendum", IDReferendum);
                            insertCommand.Parameters.AddWithValue("@SiNo", SiNo);
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Dispose();
                        }
                    }
                    selectCommand.Dispose();
                    drFundUser.Close();
                }

                // Fund table
                strquery = "SELECT * FROM Referendum WHERE ID=@ID";
                OleDbCommand cmdR = new OleDbCommand();
                cmdR.CommandText = strquery;
                cmdR.Connection = conn;
                cmdR.Parameters.Add("@ID", OleDbType.Char).Value = IDReferendum.ToString();
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


                    strquery = "UPDATE Referendum SET [Si]=?, [No]=? WHERE [ID]=? ";
                    using (OleDbCommand updateCommand = new OleDbCommand(strquery, conn))
                    {
                        updateCommand.Parameters.AddWithValue("@Si", SI);
                        updateCommand.Parameters.AddWithValue("@No", NO);
                        updateCommand.Parameters.AddWithValue("@ID", IDReferendum);
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



        private int CountingReferendum(string IDReferendum, bool Mail, string SiNo, bool utente)//CountingReferendum
        {//CountingReferendum
            int records = 0; 
            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                //L'utente non ha mai votato per questo referendum
                // registro la votazione utente            

                conn.Open();

                OleDbCommand cmdRef = new OleDbCommand("InsReferendumUtenti", conn);
                cmdRef.CommandType = System.Data.CommandType.StoredProcedure;

                cmdRef.Parameters.Add("IDUtente", OleDbType.Char).Value = _IDUte;
                cmdRef.Parameters.Add("IDReferendum", OleDbType.Char).Value = IDReferendum;
                cmdRef.Parameters.Add("SiNo", OleDbType.Char).Value = SiNo;
                records = cmdRef.ExecuteNonQuery();

                cmdRef.Dispose();
                conn.Close();

                if (records <= 0)
                    return 1;

                // aggiorno il conteggio della tabella Referendum

                if (records > 0 && utente)
                {
                    string stringa = "SELECT * FROM Referendum WHERE ID=@ID";

                    conn.Open();

                    OleDbCommand cmdR = new OleDbCommand();
                    cmdR.CommandText = stringa;
                    cmdR.Connection = conn;
                    cmdR.Parameters.Add("@ID", OleDbType.Char).Value = IDReferendum;
                    OleDbDataReader drR;
                    drR = cmdR.ExecuteReader();

                    if (drR.Read())
                    {
                        int SI = 0;
                        int NO = 0;
                        int Risultato = 0;

                        SI = int.Parse(drR.GetValue(4).ToString());
                        NO = int.Parse(drR.GetValue(5).ToString());
                        Risultato = int.Parse(drR.GetValue(6).ToString());

                        drR.Close();
                        cmdR.Dispose();
                        conn.Close();

                        if (SiNo == "SI")
                            SI = SI + 1;
                        else
                            NO = NO + 1;

                        Risultato = SI - NO;

                        conn.Open();

                        OleDbCommand cmdRefe = new OleDbCommand("UpdateReferendum", conn);
                        cmdRefe.CommandType = System.Data.CommandType.StoredProcedure;
                        cmdRefe.Parameters.Add("SI", OleDbType.Integer).Value = SI;
                        cmdRefe.Parameters.Add("NO", OleDbType.Integer).Value = NO;
                        cmdRefe.Parameters.Add("Risultato", OleDbType.Integer).Value = Risultato;
                        cmdRefe.Parameters.Add("ID", OleDbType.Integer).Value = int.Parse(IDReferendum);

                        records = cmdRefe.ExecuteNonQuery();

                        if (records > 0)
                            return 2;
                        else
                            return 1;
                    }
                    else
                        return 1;
                }
                else
                    return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return 1;
            }
            finally
            {
                conn.Close();
            }
        }

        public void sendEmailForConfirm(string email, string Token)//SendEmail Confirm
        {
            string collegamento = "http://localhost:65343/ConfermaToken.aspx?codice=" + Token;
            string vedi = "http://localhost:65343/ConfermaToken.aspx";
            //invio messaggio di posta elettronica
            string dest = email;
            string mitt = "articolo75@gmail.com";
            string mes = "Benvenuto su Articolo75.it! La tua Volontà, qui conta davvero!<br />" +
                         "A questo punto:<br />" +
                         "<br />1) CONCLUDI L'ISCRIZIONE - :";
            string msg = "<br /><br />Poi:" +
                         "<br /><br />2) VERIFICA: prima di partecipare guarda <span style=\"color:black;font-weight:bold\">CHI fa COSA e COME - CHI CI GUADAGNA</span> (diffida delle imitazioni)" +
                         "<br /><br />3) INFORMATI: vedi <a href=\"" + vedi + "\"" + ">l'elenco delle proposte di Referendum</a>, le prime proposte on-line inserite da semplici cittadini." +
                         "<br /><br />4) DIFFONDI" +
                         "<br /><br />5) PARTECIPA" +
                         "<br /><br />Leggi bene la pagina <span style=\"color:black;font-weight:bold\">\"Il Progetto\"</span>. SCOPRIRAI che con un clic ed una passeggiata," +
                         "<br />SI POSSONO ABROGARE leggi ingiuste in modo totalmente legale." +
                         "<br />Diversamente dalle inconcludenti petizioni diffuse sulla rete o nei social network," +
                         "<br />questo sito permette ad ogni cittadino di organizzare raccolte firme on-line, che" +
                         "<br />diverranno LEGALMENTE VALIDE con un clic ed una passeggiata!" +
                         "<br />Tutto questo grazie all'operato dell'Associazione <span style=\"color:black;font-weight:bold\">\"Articolo75.it\"</span>. Un'associazione" +
                         "<br />apartitica e senza scopi di lucro (vedi lo <span style=\"color:black;font-weight:bold\">statuto</span>), i cui membri si fanno garanti delle" +
                         "<br />volontà individuali e i cui <span style=\"color:black;font-weight:bold\">fondi verranno ridistribuiti a progetti (liberamente proposti" +
                         "<br />e democraticamente votati da tutti i partecipanti) ad altre Associazioni apartitiche e" +
                         "<br />senza scopi di lucro.</span>";

            string ogg = "Articolo75.it - CLICCA PER CONFERMARE LA TUA SCELTA (verifichiamo che non sei un robot) - user e password - tutto su Articolo75";

            string mailServerName = "out.alice.it";
            bool inviato = false;
            CEmail posta = new CEmail(mitt, dest, mes, collegamento, msg, ogg, mailServerName);
            inviato = posta.Invio();
        }


        public void SendEmailConfirm(string email, string Token, string strpassword="")//SendEmail Confirm
        {
            //string collegamento = "http://www.Articolo75.it/ConfermaToken.aspx?codice=" + Token;
            //string collegamento = "http://localhost:65343/ConfermaToken.aspx?codice=" + Token;
            string collegamento = "http://185.117.152.92:8081/ConfermaToken.aspx?codice=" + Token;
            //string vedi = "http://www.Articolo75.it/ConfermaToken.aspx";
            //string vedi = "http://localhost:65343/ConfermaToken.aspx";
            string vedi = "http://185.117.152.92:8081/ConfermaToken.aspx";
            //invio messaggio di posta elettronica
            string dest = email;
            string mitt = "articolo75@gmail.com";
            string mes = "Benvenuto su Articolo75.it! La tua Volontà, qui conta davvero!<br />" +
                         "A questo punto:<br />" +
                         "<br />1) CONCLUDI L'ISCRIZIONE - :";
            string msg = "<br /><br />Poi:" +
                         "<br /><br />2) VERIFICA: prima di partecipare guarda <span style=\"color:black;font-weight:bold\">CHI fa COSA e COME - CHI CI GUADAGNA</span> (diffida delle imitazioni)" +
                         "<br /><br />3) INFORMATI: vedi <a href=\"" + vedi + "\"" + ">l'elenco delle proposte di Referendum</a>, le prime proposte on-line inserite da semplici cittadini." +
                         "<br /><br />4) DIFFONDI" +
                         "<br /><br />5) PARTECIPA" +
                         "<br /><br />Leggi bene la pagina <span style=\"color:black;font-weight:bold\">\"Il Progetto\"</span>. SCOPRIRAI che con un clic ed una passeggiata," +
                         "<br />SI POSSONO ABROGARE leggi ingiuste in modo totalmente legale." +
                         "<br />Diversamente dalle inconcludenti petizioni diffuse sulla rete o nei social network," +
                         "<br />questo sito permette ad ogni cittadino di organizzare raccolte firme on-line, che" +
                         "<br />diverranno LEGALMENTE VALIDE con un clic ed una passeggiata!" +
                         "<br />Tutto questo grazie all'operato dell'Associazione <span style=\"color:black;font-weight:bold\">\"Articolo75.it\"</span>. Un'associazione" +
                         "<br />apartitica e senza scopi di lucro (vedi lo <span style=\"color:black;font-weight:bold\">statuto</span>), i cui membri si fanno garanti delle" +
                         "<br />volontà individuali e i cui <span style=\"color:black;font-weight:bold\">fondi verranno ridistribuiti a progetti (liberamente proposti" +
                         "<br />e democraticamente votati da tutti i partecipanti) ad altre Associazioni apartitiche e" +
                         "<br />senza scopi di lucro.</span>";

            string ogg = "Articolo75.it - CLICCA PER CONFERMARE LA TUA SCELTA (verifichiamo che non sei un robot) - user e password - tutto su Articolo75";

            string mailServerName = "out.alice.it";
            bool inviato = false;
            CEmail posta = new CEmail(mitt, dest, mes, collegamento, msg, ogg, mailServerName, strpassword);
            inviato = posta.Invio();
        }

        public bool ValidateToken(string token)
        {
            int records = 0;
            CKeyGenerator Key = new CKeyGenerator();
            string Pass = Key.GetUniqueKey(6, true);
            _Password = Pass;

            string strConn = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand("UPDATEUte", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                OleDbParameter Data = new OleDbParameter();
                Data = cmd.Parameters.Add("Data", OleDbType.Date);
                Data.Value = DateTime.Today;
                OleDbParameter Password = new OleDbParameter();
                Password = cmd.Parameters.Add("Password", OleDbType.Char);
                Password.Value = Pass;
                OleDbParameter Tok = new OleDbParameter();
                Tok = cmd.Parameters.Add("Token", OleDbType.Char);
                Tok.Value = token;
                records = cmd.ExecuteNonQuery();

                if (records > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public void SendPassword(string email)//sending e-mail message
        {
            //invio messaggio di posta elettronica //sending e-mail message
            string dest = email;
            string mitt = "articolo75@gmail.com";
            string mes = "Articolo75.it ti ha assegnato la password <span style=\"color:black;font-weight:bold\">" + _Password + "</span>" +
                         "<br />" +
                         "<br />" +
                         "A questo punto ti puoi loggare direttamente dal sito." +
                         "<br />" +
                         "Ti ricordiamo inoltre che la password è modificabile." +
                         "<br />" +
                         "<br />" +
                         "La User Name è la tua casella di posta" +
                         "<br />" +
                         "<br />" +
                         "A presto.";
            string msg = "";

            string ogg = "Articolo75.it - user e password - tutto su Articolo75";

            string mailServerName = "out.alice.it";
            bool inviato = false;
            CEmail posta = new CEmail(mitt, dest, mes, "", msg, ogg, mailServerName);
            inviato = posta.Invio();
        }
    }
}