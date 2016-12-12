using System.Collections.Generic;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class Delete : Form
    {
        bool notyet = false;
        public Delete()
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
                    "Таблица поставок заводов"

                }
            };
            cmbxTables.DataSource = bindingSource;
            cmbxTables.SelectedIndex = -1;
            notyet = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            switch (cmbxTables.Text)
            {
                case "Таблица поставщиков":
                    {
                        #region TableSup

                        if (textBox1.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                           TableSupplier tableSupplier = new TableSupplier();
                            tableSupplier.Delete(textBox1.Text);
                        }

                        break;
                        #endregion
                    }

                case "Таблица игр":
                    {
                        #region TableGames

                        if (textBox1.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            TableGames tableGames = new TableGames();
                            tableGames.Delete(textBox1.Text);
                        }

                        break;

                        #endregion

                    }
                case "Таблица работников":
                    {
                        #region TableWorkers

                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            TableWorkers tableWorkers = new TableWorkers();
                            tableWorkers.Delete(textBox1.Text);
                        }

                        break;

                        #endregion

                    }
                case "Таблица клиентов":
                    {
                        #region TableClient

                        if (textBox1.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            TableClient tableClient = new TableClient();
                            tableClient.Delete(textBox1.Text);
                        }

                        break;

                        #endregion

                    }
                case "Таблица аксессуаров":
                    {
                        #region TableAccessory

                        if (textBox1.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            TableAccessory tableAccessory = new TableAccessory();
                            tableAccessory.Delete(textBox1.Text);
                        }

                        break;

                        #endregion

                    }
                case "Таблица покупок клиентов":
                    {
                        #region TableConnClient

                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            TableConnClient tableConnClient = new TableConnClient();
                            tableConnClient.Delete(textBox1.Text);
                        }

                        break;

                        #endregion

                    }

                case "Таблица поставок заводов":
                    {
                        #region TableConnSup
                        if (textBox1.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                           
                            TableConnSup tableConnSup = new TableConnSup();
                            tableConnSup.Delete(textBox1.Text);
                        }
                        break;

                        #endregion
                    }

            }
        }

        private void cmbxTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = string.Empty;
            label2.Text = string.Empty;
            var gap = " ";

            if (notyet)
            {
                switch (cmbxTables.Text)
                {
                    case "Таблица поставщиков":
                        {
                            #region Заголовки табл 1

                            label2.Text = "УИД поставщика";
                            break;

                            #endregion

                        }
                    case "Таблица игр":
                        {
                            #region Заголовки табл 2

                            label2.Text = "УИД игры";
                            break;

                            #endregion

                        }
                    case "Таблица работников":
                        {
                            #region Table 3

                            label2.Text = "УИД работника";
                            break;

                            #endregion
                        }
                    case "Таблица клиентов":
                        {
                            #region Заголовки Табл4

                            label2.Text = "УИД клиента";
                            break;

                            #endregion
                        }
                    case "Таблица аксессуаров":
                        {
                            #region Table 5

                            label2.Text = "УИД аксессуара";
                            break;

                            #endregion
                        }

                    case "Таблица покупок клиентов":
                        {
                            #region TableConnClient

                            label2.Text = "УИД заказа";
                            break;
                            #endregion
                        }

                    case "Таблица поставок заводов":
                        {
                            #region TableConnSup
                            label2.Text = "УИД поставки";
                            break;

                            #endregion
                        }
                }
            }
        }
    }
}
