using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    class Inchirieri
    {
        private int id;
        private DateTime dataReturnare;
        private string denumire;
        private int idFilm;
        private int idClient;

        public Inchirieri()
        {

        }

        public Inchirieri(int id, 
            DateTime dataReturnare, 
            int idFilm,
            int idClient
        ) {
            this.id = id;
            this.dataReturnare = dataReturnare;
            this.idClient = idClient;
            this.idFilm = idFilm;
            this.denumire = this.id + "COD" + this.idClient; 
        }

        public void save(string connString)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT INTO inchirieri VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("id", OleDbType.Integer).Value = this.id;
                comanda.Parameters.Add("ID_FILM", OleDbType.Integer).Value = this.idFilm;
                comanda.Parameters.Add("ID_CLIENT", OleDbType.Integer).Value = this.idClient;
                comanda.Parameters.Add("dataReturnare", OleDbType.Date).Value = this.dataReturnare;
                comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = this.denumire;

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
