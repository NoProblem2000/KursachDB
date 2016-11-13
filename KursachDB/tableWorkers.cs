using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableWorkers : IChangeDataBase
    {
       
        Select sel;
        public TableWorkers(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableWorkers(){}

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
            string stm = "SELECT * FROM tableWorkers";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableWorkers");
            sel.dataGridView1.DataSource = data.Tables["tableWorkers"];

            conn.Close();
        }

        public void Insert(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableWorkers(idWorker, firstNameWorker, secondNameWorker, mail, telephone)
                              VALUES(@idWorker, @firstNameWorker, @secondNameWorker, @mail, @telephone)"
            };
            cmd.Parameters.AddWithValue("@idWorker", list[0]);
            cmd.Parameters.AddWithValue("@firstNameWorker", list[1]);
            cmd.Parameters.AddWithValue("@secondNameWorker", list[2]);
            cmd.Parameters.AddWithValue("@mail", list[3]);
            cmd.Parameters.AddWithValue("@telephone", list[4]);
            cmd.ExecuteNonQuery();
            conn.Close();
            
            Connect();
            var cmd2 = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableConnSup (idOrder, tableGames_idGame, tableAccessory_idAccessory, tableSupplier_idSupplier, tableWorkers_idWorker)
                                VALUES(@idOrder, @tableGames_idGame, @tableAccessory_idAccessory, @tableSupplier_idSupplier,@tableWorkers_idWorker )"
            };
            cmd2.Parameters.AddWithValue("@idOrder", list[5]);
            cmd2.Parameters.AddWithValue("@tableGames_idGame", list[7]);
            cmd2.Parameters.AddWithValue("@tableAccessory_idAccessory", list[8]);
            cmd2.Parameters.AddWithValue("@tableSupplier_idSupplier", list[6]);
            cmd2.Parameters.AddWithValue("@tableWorkers_idWorker", list[0]);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableWorkers SET secondNameWorker = @secondNameWorker,telephone = @telephone
                                WHERE idWorker = @idWorker"
            };
            cmd.Parameters.AddWithValue("@idWorker", list[0]);
            cmd.Parameters.AddWithValue("@secondNameWorker", list[1]);
            cmd.Parameters.AddWithValue("@telephone", list[2]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableWorkers
                                WHERE idWorker = @idWorker"
            };
            cmd.Parameters.AddWithValue("@idWorker", delId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectFields(string filterRow)
        {
            Connect();
            string stm = @"SELECT * FROM tableWorkers
                           WHERE secondNameWorker = @secondNameWorker
                           ORDER BY telephone";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@secondNameWorker", filterRow);
            MySqlDataAdapter mAdapter = new MySqlDataAdapter();
            mAdapter.SelectCommand = cmd;
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableWorkers");
            sel.dataGridView1.DataSource = data.Tables[0];

            conn.Close();
        }
    }
}