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
                        break;
                    }

                    case "2":
                    {
                        TableGames tableGames = new TableGames(this);
                        tableGames.Select();
                        break;
                    }
                    case "3":
                    {
                        TableWorkers tableWorkers = new TableWorkers(this);
                        tableWorkers.Select();
                        break;
                    }
                    case "4":
                    {
                        TableClient tableClient = new TableClient(this);
                        tableClient.Select();
                        break;
                    }
                    case "5":
                    {
                        TableAccessory tableAccessory = new TableAccessory(this);
                        tableAccessory.Select();
                        break;
                    }
                }
            }

        }
    }
}
