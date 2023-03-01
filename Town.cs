using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Utils;

namespace TicariOtomasyon
{
    public class Town
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public List<Town> towns;

        public Town()
        {
            towns = new List<Town>();
        }
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int City { get; set; }
        
        public List<Town> GetTowns(int id)
        {
            
            _connection = new SqlDatabaseConnection();
            _sqlCommand = new SqlCommand("select * from Towns where City=@CityId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@CityId", id);
            
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            
            while (reader.Read())
            {
                Town town = new Town
                {
                    TownId = Convert.ToInt32(reader["TownId"]),
                    TownName = reader["TownName"].ToString(),
                    City = Convert.ToInt32(reader["City"])
                };
                
                towns.Add(town);
            }
            _connection.Connection().Close();
            return towns;
        }
    }
}
