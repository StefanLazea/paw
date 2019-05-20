using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    class Categorii
    {
        private int id;
        private string denumire;
        
        public Categorii(int id, string denumire)
        {
            this.id = id;
            this.denumire = denumire;
        }

        public override string ToString()
        {
            return this.denumire;
        }

        public static List<Categorii> getAllCategories(string connString, int userId, string arguments)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM categorii");

            List<Categorii> listaCategorii = new List<Categorii>();
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string denumire = reader["denumire"].ToString();

                    listaCategorii.Add(new Categorii(id, denumire));
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
    }
}
