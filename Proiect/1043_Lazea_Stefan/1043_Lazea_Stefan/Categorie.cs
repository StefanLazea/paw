using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    public class Categorie
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

        public int Id
        {
            get { return this.id; }
        }

        public string Denumire
        {
            get { return this.denumire; }
        }

        public static List<Categorie> getAllCategories(string connString)
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
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM categorii WHERE id="+categoryId, conexiune);

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

        public static int getCategoryIdByName(string connString, string denumire)
        {


            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT id from categorii where denumire='" + denumire + "'", conn);
            try
            {
                conn.Open();

                return Convert.ToInt32(comanda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        public static string findCategoryNameById(string connString, int idCategory)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT denumire from categorii where id=" + idCategory , conn);

           
            try
            {
                conn.Open();

                return Convert.ToString(comanda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
