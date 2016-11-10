using System;
using System.Collections.Generic;
using System.Linq;
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            switch (cmbxTables.Text)
            {
                case "1":
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

                case "2":
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
                case "3":
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
                case "4":
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
                case "5":
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
                case "6":
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

                case "7":
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
                    case "1":
                        {
                            #region Заголовки табл 1

                            label2.Text = "УИД поставщика";
                            break;

                            #endregion

                        }
                    case "2":
                        {
                            #region Заголовки табл 2

                            label2.Text = "УИД игры";
                            break;

                            #endregion

                        }
                    case "3":
                        {
                            #region Table 3

                            label2.Text = "УИД работника";
                            break;

                            #endregion
                        }
                    case "4":
                        {
                            #region Заголовки Табл4

                            label2.Text = "УИД клиента";
                            break;

                            #endregion
                        }
                    case "5":
                        {
                            #region Table 5

                            label2.Text = "УИД аксессуара";
                            break;

                            #endregion
                        }

                    case "6":
                        {
                            #region TableConnClient

                            label2.Text = "УИД заказа";
                            break;
                            #endregion
                        }

                    case "7":
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
