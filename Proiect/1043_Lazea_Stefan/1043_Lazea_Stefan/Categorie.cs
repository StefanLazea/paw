using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    class Categorie
    {
        private int id;
        private string denumire;
        
        public Categorie()
        {

        }

        public Categorie(int id, string denumire)
        {
            this.id = id;
            this.denumire = denumire;
        }

        public override string ToString()
        {
            return this.denumire;
        }

        public string Denumire
        {
            get { return this.denumire; }
        }

        public static List<Categorie> getAllCategories(string connString, string arguments)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM categorii", conexiune);

            List<Categorie> listaCategorii = new List<Categorie>();
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string denumire = reader["denumire"].ToString();

                    listaCategorii.Add(new Categorie(id, denumire));
                }
                return listaCategorii;
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

        public static Categorie getOneById(string connString, int categoryId, string arguments)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM categorii WHERE id="+categoryId);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                Categorie category = new Categorie(); 
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string denumire = reader["denumire"].ToString();

                    category = new Categorie(id, denumire);
                }
                return category;
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
