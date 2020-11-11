using System.Collections.Generic;
using System.Data.SqlClient;
using WineCollectionApp.Models;

namespace WineCollectionApp.Data
{
    public class DatabaseContext
    {
        private SqlConnection con;
        private SqlCommand cmd;

        private void Connection()
        {
            string constr = "Data Source=.;Initial Catalog=WineCollection;Integrated Security=False;User Id=TEST;Password=123456";
            con = new SqlConnection(constr);
        }

        public List<Producer> GetAllProducers()
        {
            Connection();
            string query = "SELECT * FROM [dbo].[Producer]";

            List<Producer> producers = new List<Producer>();

            using (cmd = new SqlCommand(query, con))
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producer prod = new Producer();
                    prod.Id = (int)reader["id"];
                    prod.Name = (string)reader["name"];
                    prod.Address = (reader["address"] == System.DBNull.Value) ? null : (string)reader["address"];
                    producers.Add(prod);
                }
            }

            return producers;
        }

        public void AddProducer(Producer prod)
        {            
            Connection();
            string query = string.Format("INSERT INTO [dbo].[Producer] ([name],[address]) VALUES ('{0}' ,'{1}')", prod.Name, prod.Address);
            int result;
            using (cmd = new SqlCommand(query, con))
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
        }

        public List<Bottle> GetAllBottlesFromProducerById(int id)
        {
            List<Bottle> bottles = new List<Bottle>();

            Connection();
            string query = string.Format("SELECT * FROM [dbo].[Bottle] WHERE [producer_id] = {0}", id);

            using (cmd = new SqlCommand(query, con))
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Bottle bot = new Bottle();
                    bot.Id = (int)reader["id"];
                    bot.ProducerId = (reader["producer_id"] == System.DBNull.Value) ? null : (int?)reader["producer_id"];
                    bot.Name = (string)reader["name"];
                    bot.Year = (reader["year"] == System.DBNull.Value) ? null : (int?)reader["year"];
                    bot.Size = (reader["size"] == System.DBNull.Value) ? null : (int?)reader["size"];
                    bot.Style = (reader["style"] == System.DBNull.Value) ? null : (string)reader["style"];
                    bot.Taste = (reader["taste"] == System.DBNull.Value) ? null : (string)reader["taste"];
                    bot.Description = (reader["description"] == System.DBNull.Value) ? null : (string)reader["description"];
                    bot.FoodPairing = (reader["food_pairing"] == System.DBNull.Value) ? null : (string)reader["food_pairing"];
                    bot.Link = (reader["link"] == System.DBNull.Value) ? null : (string)reader["link"];
                    bottles.Add(bot);
                }
            }

            return bottles;
        }

        public void AddBottle(Bottle bottle)
        {            
            Connection();
            string query = string.Format("INSERT INTO [dbo].[Bottle] ([producer_id],[name],[year],[size],[style],[taste],[description],[food_pairing],[link])"
                + " VALUES ({0},'{1}',{2},{3},'{4}','{5}','{6}','{7}','{8}')",
                bottle.ProducerId, bottle.Name, bottle.Year, bottle.Size, bottle.Style, bottle.Taste, bottle.Description, bottle.FoodPairing, bottle.Link);
            
            int result;
            using (cmd = new SqlCommand(query, con))
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBottle(int id)
        {
            Connection();
            string query = string.Format("DELETE FROM [dbo].[Bottle] WHERE id = {0}", id);
            
            int result;
            using (cmd = new SqlCommand(query, con))
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
        }
    }
}
