using System.Collections.Generic;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class Select : Form
    {
        bool notyet = false;
        public Select()
        {
            InitializeComponent();
            var bindingSource = new BindingSource
            {
                DataSource = new List<string>()
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7"
                }
            };
            cmbxTables.DataSource = bindingSource;
            cmbxTables.SelectedIndex = -1;
            notyet = true;
        }

        private void cmbxTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (notyet)
            {
                switch (cmbxTables.Text)
                {
                    case "1":
                    {
                        TableSupplier tableSupplier = new TableSupplier(this);
                        tableSupplier.Select();
                        label2.Text = "Название завода";
                        break;
                    }

                    case "2":
                    {
                        TableGames tableGames = new TableGames(this);
                        tableGames.Select();
                        label2.Text = "Название игры";
                        break;
                    }
                    case "3":
                    {
                        TableWorkers tableWorkers = new TableWorkers(this);
                        tableWorkers.Select();
                        label2.Text = "Фамилия работника";
                        break;
                    }
                    case "4":
                    {
                        TableClient tableClient = new TableClient(this);
                        tableClient.Select();
                        label2.Text = "Фамилия клиента";
                        break;
                    }
                    case "5":
                    {
                        TableAccessory tableAccessory = new TableAccessory(this);
                        tableAccessory.Select();
                        label2.Text = "Название аксессуара";
                        break;
                    }
                    case "6":
                    {
                        TableConnClient tableConnClient = new TableConnClient(this);
                        tableConnClient.Select();
                        break;
                    }
                    case "7":
                    {
                        TableConnSup tableConnSup = new TableConnSup(this);
                        tableConnSup.Select();
                        break;
                    }
                    case "View1":
                    {
                        TableGames tableGames = new TableGames();
                        tableGames.SelectViews();
                        break;
                    }
                    case "View2":
                    {
                        TableConnClient tableConnClient = new TableConnClient();
                        tableConnClient.SelectView();
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            switch (cmbxTables.Text)
            {
                case "1":
                {
                    TableSupplier tableSupplier = new TableSupplier(this);
                    tableSupplier.SelectFields(textBox1.Text);
                    break;
                }

                case "2":
                {
                    TableGames tableGames = new TableGames(this);
                    tableGames.SelectFields(textBox1.Text);
                    break;
                }
                case "3":
                {
                    TableWorkers tableWorkers = new TableWorkers(this);
                    tableWorkers.SelectFields(textBox1.Text);
                    break;
                }
                case "4":
                {
                    TableClient tableClient = new TableClient(this);
                    tableClient.SelectFields(textBox1.Text);
                    break;
                }
                case "5":
                {
                    TableAccessory tableAccessory = new TableAccessory(this);
                    tableAccessory.SelectFields(textBox1.Text);
                    break;
                }
            }
        }
    }
}
