using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableSupplier : IChangeDataBase
    {
        Select sel;
        public TableSupplier(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableSupplier(){}

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
            string stm = "SELECT * FROM tableSupplier";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableSupplier");
            sel.dataGridView1.DataSource = data.Tables["tableSupplier"];

            conn.Close();
        }

        public void Insert(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableSupplier(idSupplier, NameRefinery, focalPerson, telephone, city, street, house, flat)
                              VALUES(@idSupplier, @NameRefinery, @focalPerson, @telephone, @city, @street, @house, @flat)"
            };
            cmd.Parameters.AddWithValue("@idSupplier", list[0]);
            cmd.Parameters.AddWithValue("@NameRefinery", list[1]);
            cmd.Parameters.AddWithValue("@focalPerson", list[2]);
            cmd.Parameters.AddWithValue("@telephone", list[3]);
            cmd.Parameters.AddWithValue("@city", list[4]);
            cmd.Parameters.AddWithValue("@street", list[5]);
            cmd.Parameters.AddWithValue("@house", list[6]);
            cmd.Parameters.AddWithValue("@flat", list[7]);
           
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(List<string> list )
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableSupplier SET focalPerson = @focalPerson, telephone = @telephone
                                WHERE idSupplier = @idSupplier"
            };
            cmd.Parameters.AddWithValue("@idSupplier", list[0]);
            cmd.Parameters.AddWithValue("@focalPerson",list[1]);
            cmd.Parameters.AddWithValue("@telephone",list[2]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableSupplier 
                                WHERE idSupplier = @idSupplier"
            };
            cmd.Parameters.AddWithValue("@idSupplier", delId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectFields(string filterRow)
        {
            Connect();
            string stm = @"SELECT * FROM tableSupplier
                           WHERE NameRefinery = @NameRefinery
                           ORDER BY focalPerson";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@NameRefinery", filterRow);
            MySqlDataAdapter mAdapter = new MySqlDataAdapter();
            mAdapter.SelectCommand = cmd;
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableSupplier");
            sel.dataGridView1.DataSource = data.Tables[0];

            conn.Close();
        }
    }
}