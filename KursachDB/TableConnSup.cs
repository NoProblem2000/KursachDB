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

        public void Update()
        {
            throw new System.NotImplementedException();
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