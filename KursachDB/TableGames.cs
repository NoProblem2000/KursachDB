using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableGames : IChangeDataBase
    {
        Select sel;
        public TableGames(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableGames(){}

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
            string stm = "SELECT * FROM tableGames";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableGames");
            sel.dataGridView1.DataSource = data.Tables["tableGames"];

            conn.Close();
        }

        public void Insert(List<string> list )
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableGames(idGame, nameGame, price, typeGame, colPlayers, timeGame)
                              VALUES(@idGame, @nameGame, @price, @typeGame, @colPlayers, @timeGame)"
            };
            cmd.Parameters.AddWithValue("@idGame", list[0]);
            cmd.Parameters.AddWithValue("@nameGame", list[1]);
            cmd.Parameters.AddWithValue("@price", list[2]);
            cmd.Parameters.AddWithValue("@typeGame", list[3]);
            cmd.Parameters.AddWithValue("@colPlayers", list[4]);
            cmd.Parameters.AddWithValue("@timeGame", list[5]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableGames SET price = @priсe
                                WHERE idGame = @idGame"
            };
            cmd.Parameters.AddWithValue("@idGame", list[0]);
            cmd.Parameters.AddWithValue("@priсe", list[1]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableGames
                                WHERE idGame = @idGame"
            };
            cmd.Parameters.AddWithValue("@idGame", delId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectFields(string filterRow)
        {
            Connect();
            string stm = @"SELECT * FROM tableGames
                           WHERE nameGame = @nameGame
                           ORDER BY price";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@nameGame", filterRow);
            MySqlDataAdapter mAdapter = new MySqlDataAdapter();
            mAdapter.SelectCommand = cmd;
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableGames");
            sel.dataGridView1.DataSource = data.Tables[0];

            conn.Close();
        }

        public void SelectViews()
        {
            Connect();
            string stm = "SELECT * FROM view1";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "view1");
            sel.dataGridView1.DataSource = data.Tables["view1"];

            conn.Close();
        }
    }
}