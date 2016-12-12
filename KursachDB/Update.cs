using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class Update : Form
    {
        bool notyet = false;
        public Update()
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

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty
                            || textBox3.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableSupplier tableSupplier = new TableSupplier();
                            tableSupplier.Update(listData);
                        }

                        break;
                        #endregion
                    }

                case "Таблица игр":
                    {
                        #region TableGames

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableGames tableGames = new TableGames();
                            tableGames.Update(listData);
                        }

                        break;

                        #endregion

                    }
                case "Таблица работников":
                    {
                        #region TableWorkers

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                         textBox3.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableWorkers tableWorkers = new TableWorkers();
                            tableWorkers.Update(listData);
                        }

                        break;

                        #endregion

                    }
                case "Таблица клиентов":
                    {
                        #region TableClient

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                         textBox3.Text == string.Empty || textBox4.Text == string.Empty 
                         || textBox5.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableClient tableClient = new TableClient();
                            tableClient.Update(listData);
                        }

                        break;

                        #endregion

                    }
                case "Таблица аксессуаров":
                    {
                        #region TableAccessory

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty )
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableAccessory tableAccessory = new TableAccessory();
                            tableAccessory.Update(listData);
                        }

                        break;

                        #endregion

                    }
                case "Таблица покупок клиентов":
                    {
                        #region TableConnClient

                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                        textBox3.Text == string.Empty || textBox4.Text == string.Empty
                            || textBox5.Text == string.Empty)
                        {
                            MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                        }
                        else
                        {
                            var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5

                            };
                            var listData = listObjects.Select(t => t.Text).ToList();

                            TableConnClient tableConnClient = new TableConnClient();
                            tableConnClient.Update(listData);
                        }

                        break;

                        #endregion

                    }

                case "Таблица поставок заводов":
                {
                    #region TableConnSup
                    if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                        textBox3.Text == string.Empty || textBox4.Text == string.Empty
                            || textBox5.Text == string.Empty)
                    {
                        MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                    }
                    else
                    {
                        var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5

                            };
                        var listData = listObjects.Select(t => t.Text).ToList();

                        TableConnSup tableConnSup = new TableConnSup();
                        tableConnSup.Update(listData);
                    }
                    break;

                    #endregion
                }

            }
        }

        private void cmbxTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var listTextBoxs = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5
            };

            foreach (var item in listTextBoxs)
            {
                item.Enabled = true;
                item.Text = string.Empty;
            }
            label2.Text = string.Empty;
            var gap = " ";

            if (notyet)
            {
                switch (cmbxTables.Text)
                {
                    case "Таблица поставщиков":
                        {
                            #region Заголовки табл 1

                            label2.Text = "УИД поставщика" + String.Concat(Enumerable.Repeat(gap, 15)) + "Контактное лицо" + String.Concat(Enumerable.Repeat(gap, 15)) + "Телефон";
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            break;

                            #endregion

                        }
                    case "Таблица игр":
                        {
                            #region Заголовки табл 2

                            label2.Text = "УИД игры" + String.Concat(Enumerable.Repeat(gap, 30)) + "Цена";
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            break;

                            #endregion

                        }
                    case "Таблица работников":
                        {
                            #region Table 3

                            label2.Text = "УИД работника" + String.Concat(Enumerable.Repeat(gap, 15)) + "Фамилия работника" + String.Concat(Enumerable.Repeat(gap, 10)) + "Телефон";
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            break;

                            #endregion
                        }
                    case "Таблица клиентов":
                        {
                            #region Заголовки Табл4

                            label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 40)) + "Фамилия" + String.Concat(Enumerable.Repeat(gap, 30)) + "Улица" + String.Concat(Enumerable.Repeat(gap, 25)) + "Дом" + String.Concat(Enumerable.Repeat(gap, 35)) + "Квартира";
                            break;

                            #endregion
                        }
                    case "Таблица аксессуаров":
                        {
                            #region Table 5

                            label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 35)) + "Цена";
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            break;

                            #endregion
                        }

                    case "Таблица покупок клиентов":
                        {
                            #region TableConnClient

                            label2.Text = "УИД заказа" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД Аксессуара" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД игры" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД покупателя" + String.Concat(Enumerable.Repeat(gap, 15)) + "УИД работника";
                            break;
                            #endregion
                        }

                    case "Таблица поставок заводов":
                    {
                        #region TableConnSup
                        label2.Text = "УИД поставки" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД игры" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД аксессуара" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД поставщика" + String.Concat(Enumerable.Repeat(gap, 10)) + "УИД работника";
                        break;

                        #endregion
                    }
                }
            }
        }
    }
}
