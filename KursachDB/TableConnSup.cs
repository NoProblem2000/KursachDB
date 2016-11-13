using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableConnSup:IChangeDataBase
    {
        Select sel;
        public TableConnSup(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableConnSup(){}

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
            string stm = "SELECT * FROM tableConnSup";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableConnSup");
            sel.dataGridView1.DataSource = data.Tables["tableConnSup"];

            conn.Close();
        }

        public void Insert(List<string> list )
        {
            throw new System.NotImplementedException();
        }

        public void Update(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableConnSup SET tableGames_idGame = @tableGames_idGame, tableAccessory_idAccessory = @tableAccessory_idAccessory, tableSupplier_idSupplier = @tableSupplier_idSupplier, tableWorkers_idWorker = @tableWorkers_idWorker
                                WHERE idOrder = @idOrder"
            };
            cmd.Parameters.AddWithValue("@idOrder", list[0]);
            cmd.Parameters.AddWithValue("@tableGames_idGame", list[1]);
            cmd.Parameters.AddWithValue("@tableAccessory_idAccessory", list[2]);
            cmd.Parameters.AddWithValue("@tableSupplier_idSupplier", list[3]);
            cmd.Parameters.AddWithValue("@tableWorkers_idWorker", list[4]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableConnSup 
                                WHERE idOrder = @idOrder"
            };
            cmd.Parameters.AddWithValue("@idOrder", delId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectFields(string filterRow)
        {
            throw new System.NotImplementedException();
        }
    }
}