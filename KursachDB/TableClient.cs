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

        public void Insert()
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