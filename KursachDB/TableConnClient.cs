using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableConnClient:IChangeDataBase
    {
         Select sel;
        public TableConnClient(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableConnClient(){}

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
            string stm = "SELECT * FROM tableConnClient";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableConnClient");
            sel.dataGridView1.DataSource = data.Tables["tableConnClient"];

            conn.Close();
        }

        public void Insert(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableConnClient(idOrder, tableAccessory_idAccessory, tableGames_idGame, tableClient_idClient, tableWorkers_idWorker)
                              VALUES(@idOrder, @tableAccessory_idAccessory, @tableGames_idGame, @tableClient_idClient, @tableWorkers_idWorker)"
            };
            cmd.Parameters.AddWithValue("@idOrder", list[0]);
            cmd.Parameters.AddWithValue("@tableAccessory_idAccessory", list[1]);
            cmd.Parameters.AddWithValue("@tableGames_idGame", list[2]);
            cmd.Parameters.AddWithValue("@tableClient_idClient", list[3]);
            cmd.Parameters.AddWithValue("@tableWorkers_idWorker", list[4]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       
        public void Update(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableConnClient SET tableAccessory_idAccessory = @tableAccessory_idAccessory, tableGames_idGame = @tableGames_idGame,tableClient_idClient = @tableClient_idClient, tableWorkers_idWorker = @tableWorkers_idWorker 
                                WHERE idOrder = @idOrder"
            };
            cmd.Parameters.AddWithValue("@idOrder", list[0]);
            cmd.Parameters.AddWithValue("@tableAccessory_idAccessory", list[1]);
            cmd.Parameters.AddWithValue("@tableGames_idGame", list[2]);
            cmd.Parameters.AddWithValue("@tableClient_idClient", list[3]);
            cmd.Parameters.AddWithValue("@tableWorkers_idWorker", list[4]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void SelectFields()
        {
            throw new System.NotImplementedException();
        }
    }
}