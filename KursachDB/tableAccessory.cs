﻿using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace KursachDB
{
    class TableAccessory : IChangeDataBase
    {
         Select sel;
        public TableAccessory(Select sel)
        {
            this.sel = sel;
        }
        public MySqlConnection conn;

        public TableAccessory(){}

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
            string stm = "SELECT * FROM tableAccessory";
            MySqlDataAdapter mAdapter = new MySqlDataAdapter(stm, conn);
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableAccessory");
            sel.dataGridView1.DataSource = data.Tables["tableAccessory"];

            conn.Close();
        }

        public void Insert(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"INSERT INTO tableAccessory(idAccessory, nameAccessory, price)
                              VALUES(@idAccessory, @nameAccessory, @price)"
            };
            cmd.Parameters.AddWithValue("@idAccessory", list[0]);
            cmd.Parameters.AddWithValue("@nameAccessory", list[1]);
            cmd.Parameters.AddWithValue("@price", list[2]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(List<string> list)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"UPDATE tableAccessory SET price = @price
                                WHERE idAccessory = @idAccessory"
            };
            cmd.Parameters.AddWithValue("@idAccessory", list[0]);
            cmd.Parameters.AddWithValue("@price", list[1]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string delId)
        {
            Connect();
            var cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"DELETE FROM tableAccessory 
                                WHERE idAccessory = @idAccessory"
            };
            cmd.Parameters.AddWithValue("@idAccessory", delId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectFields(string filterRow)
        {
            Connect();
            string stm = @"SELECT * FROM tableAccessory
                           WHERE nameAccessory = @nameAccessory
                           ORDER BY price";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@nameAccessory",filterRow );
            MySqlDataAdapter mAdapter = new MySqlDataAdapter();
            mAdapter.SelectCommand = cmd;
            MySqlCommandBuilder mScomBuild = new MySqlCommandBuilder(mAdapter);
            DataSet data = new DataSet();
            mAdapter.Fill(data, "tableAccessory");
            sel.dataGridView1.DataSource = data.Tables[0];

            conn.Close();
        }
    }
}