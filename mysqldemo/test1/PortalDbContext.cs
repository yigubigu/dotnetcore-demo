using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace test1
{
    public class PortalDbContext
    {
        public PortalDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Bank> GetAllBanks()  
        {  
            List<Bank> list = new List<Bank>();  
  
            using (MySqlConnection conn = GetConnection())  
            {  
                conn.Open();  
      MySqlCommand cmd = new MySqlCommand("select * from bank where id < 10", conn);  
  
                using (var reader = cmd.ExecuteReader())  
                {  
                    while (reader.Read())  
                    {  
                        list.Add(new Bank()  
                        {  
                            Id = Convert.ToInt32(reader["Id"]),  
                            BankName = reader["bank_name"].ToString(),   
                            BankCode = reader["bank_code"].ToString() 
                        });  
                    }  
                }  
                }  
                return list;  
            }  



    }
}
