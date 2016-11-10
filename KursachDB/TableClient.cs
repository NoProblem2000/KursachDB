using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableClient : IChangeDataBase
    {
        Select sel;
        public TableClient(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableClient(){}

        public void Connect()
        {
            const string cs = @"server=localhost;userid=root;password=1;database=lab1DB;CharSet=utf8;";
            conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        public void Select()
        {
            Connect();
            string stm = "SELECT * FROM tableClient";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableClient");
            sel.dataGridView1.DataSource = data.Tables["tableClient"];

            conn.Close();
        }

        public void Insert(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableClient(idClient, firstNameClient, secondNameClient, mail, country, city, street, house, flat)
                              VALUES(@idClient, @firstNameClient, @secondNameClient, @mail, @country, @city, @street, @house, @flat)"
            };
            cmd.Parameters.AddWithValue("@idClient", list[0]);
            cmd.Parameters.AddWithValue("@firstNameClient", list[1]);
            cmd.Parameters.AddWithValue("@secondNameClient", list[2]);
            cmd.Parameters.AddWithValue("@mail", list[3]);
            cmd.Parameters.AddWithValue("@country", list[4]);
            cmd.Parameters.AddWithValue("@city", list[5]);
            cmd.Parameters.AddWithValue("@street", list[6]);
            cmd.Parameters.AddWithValue("@house", list[7]);
            cmd.Parameters.AddWithValue("@flat", list[8]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(List<string> list)
        {
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableClient SET secondNameClient = @secondNameClient,street = @street,house = @house, flat = @flat 
                                WHERE idClient = @idClient"
            };
            cmd.Parameters.AddWithValue("@idClient", list[0]);
            cmd.Parameters.AddWithValue("@secondNameClient", list[1]);
            cmd.Parameters.AddWithValue("@street", list[2]);
            cmd.Parameters.AddWithValue("@house", list[3]);
            cmd.Parameters.AddWithValue("@flat", list[4]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableClient 
                                WHERE idClient = @idClient"
            };
            cmd.Parameters.AddWithValue("@idClient", delId);
            cmd.ExecuteNonQuery();
            conn.Close();   
        }

        public void SelectFields()
        {
            throw new System.NotImplementedException();
        }
    }
}