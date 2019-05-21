using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    class Clienti
    {
        private int id;
        private string nume;
        private string prenume;
        private string adresa;
        private string telefon;
        private string sex;
        private int varsta;
        private string username;
        private string password;
        
        public Clienti()
        {

        }

        public Clienti(
            int id,
            string nume, 
            string prenume, 
            string adresa,
            string telefon,
            string sex,
            int varsta,
            string username, 
            string password
        ) {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.telefon = telefon;
            this.varsta = varsta;
            this.sex = sex;
            this.username = username;
            this.password = password;
        }

        public void save(string connString)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT INTO clienti VALUES(?,?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("id", OleDbType.Integer).Value = this.id;
                comanda.Parameters.Add("nume", OleDbType.Char, 30).Value = this.nume;
                comanda.Parameters.Add("prenume", OleDbType.Char, 30).Value = this.prenume;
                comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = this.adresa;
                comanda.Parameters.Add("telefon", OleDbType.Char, 30).Value = this.telefon;
                comanda.Parameters.Add("username", OleDbType.Char, 30).Value = this.username;
                comanda.Parameters.Add("password", OleDbType.Char, 30).Value = this.password;
                comanda.Parameters.Add("varsta", OleDbType.Integer).Value = this.varsta;
                comanda.Parameters.Add("sex", OleDbType.Char, 30).Value = this.sex;
                

                comanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
