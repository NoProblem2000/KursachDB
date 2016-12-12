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
                    "Таблица поставщиков",
                    "Таблица игр",
                    "Таблица работников",
                    "Таблица клиентов",
                    "Таблица аксессуаров",
                    "Таблица покупок клиентов",
                    "Таблица поставок заводов",
                    "Просмотр стоимости всех игр",
                    "Просмотр заказов клиентов"
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
                    case "Таблица поставщиков":
                    {
                        TableSupplier tableSupplier = new TableSupplier(this);
                        tableSupplier.Select();
                        label2.Text = "Название завода";
                        break;
                    }

                    case "Таблица игр":
                    {
                        TableGames tableGames = new TableGames(this);
                        tableGames.Select();
                        label2.Text = "Название игры";
                        break;
                    }
                    case "Таблица работников":
                    {
                        TableWorkers tableWorkers = new TableWorkers(this);
                        tableWorkers.Select();
                        label2.Text = "Фамилия работника";
                        break;
                    }
                    case "Таблица клиентов":
                    {
                        TableClient tableClient = new TableClient(this);
                        tableClient.Select();
                        label2.Text = "Фамилия клиента";
                        break;
                    }
                    case "Таблица аксессуаров":
                    {
                        TableAccessory tableAccessory = new TableAccessory(this);
                        tableAccessory.Select();
                        label2.Text = "Название аксессуара";
                        break;
                    }
                    case "Таблица покупок клиентов":
                    {
                        TableConnClient tableConnClient = new TableConnClient(this);
                        tableConnClient.Select();
                        break;
                    }
                    case "Таблица поставок заводов":
                    {
                        TableConnSup tableConnSup = new TableConnSup(this);
                        tableConnSup.Select();
                        break;
                    }
                    case "Просмотр стоимости всех игр":
                    {
                        TableGames tableGames = new TableGames(this);
                        tableGames.SelectViews();
                        break;
                    }
                    case "Просмотр заказов клиентов":
                    {
                        TableConnClient tableConnClient = new TableConnClient(this);
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
                case "Таблица поставщиков":
                {
                    TableSupplier tableSupplier = new TableSupplier(this);
                    tableSupplier.SelectFields(textBox1.Text);
                    break;
                }

                case "Таблица игр":
                {
                    TableGames tableGames = new TableGames(this);
                    tableGames.SelectFields(textBox1.Text);
                    break;
                }
                case "Таблица работников":
                {
                    TableWorkers tableWorkers = new TableWorkers(this);
                    tableWorkers.SelectFields(textBox1.Text);
                    break;
                }
                case "Таблица клиентов":
                {
                    TableClient tableClient = new TableClient(this);
                    tableClient.SelectFields(textBox1.Text);
                    break;
                }
                case "Таблица аксессуаров":
                {
                    TableAccessory tableAccessory = new TableAccessory(this);
                    tableAccessory.SelectFields(textBox1.Text);
                    break;
                }
            }
        }
    }
}
