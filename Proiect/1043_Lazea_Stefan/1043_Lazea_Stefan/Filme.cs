using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace _1043_Lazea_Stefan
{
    class Filme: ICloneable, IComparable
    {
        private int id;
        private string denumire;
        private int idCategorie;
        private DateTime dataLansare;
        private double durata;
        private float pretInchiriere;

        public Filme()
        {

        }

        public Filme(
            int id,
            string denumire,
            int idCategorie, 
            DateTime dataLansare, 
            double durata, 
            float pretInchiriere
         ) {
            this.id = id;
            this.denumire = denumire;
            this.idCategorie = idCategorie;
            this.dataLansare = dataLansare;
            this.durata = durata;
            this.pretInchiriere = pretInchiriere;
        }
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }

        public int IdCategorie
        {
            get { return this.idCategorie; }
            set { this.idCategorie = value; }
        }

        public DateTime Datalansare
        {
            get { return this.dataLansare; }
            set { this.dataLansare = value; }
        }

        public double Durata
        {
            get { return this.durata; }
            set { this.durata = value; }
        }

        public float PretInchiriere
        {
            get { return this.pretInchiriere; }
            set { this.pretInchiriere = value; }
        }

        public object Clone()
        {
            Filme f = (Filme)this.MemberwiseClone();

            return f;
        }

        public int CompareTo(object obj)
        {
            Filme f = (Filme)obj;
            if(this.pretInchiriere < f.pretInchiriere)
            {
                return -1;
            }else if(this.pretInchiriere == f.pretInchiriere)
            {
                return 1;
            }
            else
            {
                return string.Compare(this.denumire, f.denumire);
            }
        }

        public override string ToString()
        {
            return "Filmul " + this.denumire + " lansat in " + this.dataLansare.ToString() + " are un pret de inchiriere de " + this.pretInchiriere +
                " lei si are o durata de " + this.durata + "\n";
        }

        public void save(string connString, string imgPath)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "Select MAX(id) FROM filme";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO filme VALUES(?,?,?,?,?,?,?)";
                comanda.Parameters.Add("id", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = this.denumire;
                comanda.Parameters.Add("id_categorie", OleDbType.Integer).Value = 3;
                comanda.Parameters.Add("dataLansare", OleDbType.Date).Value = this.dataLansare;
                comanda.Parameters.Add("durata", OleDbType.Double).Value = this.durata;
                comanda.Parameters.Add("pretInchiriere", OleDbType.Double).Value = this.pretInchiriere;
                comanda.Parameters.Add("picture", OleDbType.Char).Value = imgPath;

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

        public static List<Filme> getAllMovies(string connString)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM filme", conexiune);

            List<Filme> listaFilme = new List<Filme>();
           
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string denumire = reader["denumire"].ToString();
                    int idCategorie = Convert.ToInt32(reader["id_categorie"].ToString());
                    DateTime date = Convert.ToDateTime(reader["dataLansare"].ToString());
                    double durata = Convert.ToDouble(reader["durata"].ToString());
                    float pret = (float)Convert.ToDouble(reader["pretInchiriere"].ToString());

                    listaFilme.Add(new Filme(id, denumire, idCategorie, date, durata, pret));
                }
                return listaFilme;
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

        public static void deleteMovie(string connString, int idMovie)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                comanda.CommandText = "DELETE FROM filme WHERE id=" + idMovie;
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
