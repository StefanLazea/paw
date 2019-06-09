using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    class Recenzie
    {
        private int id;
        private int nota;
        private string descriere;
        private int idFilm;

        public Recenzie()
        {

        }

        public Recenzie(
            int id,
            int nota,
            string descriere,
            int idFilm
        ) {
            this.id = id;
            this.nota = nota;
            this.descriere = descriere;
            this.idFilm = idFilm;

        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public int Nota
        {
            get { return nota; }
            set { this.nota = value; }
        }

        public string Descriere
        {
            get
            {
                return this.descriere;
            }
            set
            {
                this.descriere = value;
            }
        }

        public int IdFilm {
            get
            {
                return this.idFilm;
            }
            set
            {
                this.idFilm = value;
            }
        }

        public void save(string connString)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "INSERT INTO recenzii VALUES(?,?,?,?)";
                comanda.Parameters.Add("id", OleDbType.Integer).Value = this.id + 1;
                comanda.Parameters.Add("descriere", OleDbType.Char).Value = this.descriere;
                comanda.Parameters.Add("ID_film", OleDbType.Integer).Value = this.idFilm;
                comanda.Parameters.Add("nota", OleDbType.Integer).Value = this.nota;
                
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

        public static float getAverageOfNotesForAMovie(string connString, int movieId)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM recenzii WHERE id=" + movieId, conexiune);

            List<Filme> listaFilme = new List<Filme>();
            int suma = 0;
            int n = 0;
            List<int> lista = new List<int>();
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    int nota = Convert.ToInt32(reader["nota"].ToString());

                    lista.Add(nota);
                }
               
                foreach(int i in lista)
                {
                    suma += i;
                }
                return (float)suma / lista.Count();
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
