using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class Insert : Form
    {
        bool notyet = false;
        public Insert()
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
                    "6"
                    
                }
            };
            cmbxTables.DataSource = bindingSource;
            cmbxTables.SelectedIndex = -1;
            notyet = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           switch (cmbxTables.Text)
                {
                    case "1":
                        {
                            #region TableSup
                           
                            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                                textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                                textBox5.Text == string.Empty || textBox6.Text == string.Empty ||
                                textBox7.Text == string.Empty || textBox8.Text == string.Empty)
                            {
                                MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                            }
                            else
                            {
                                var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8

                            };
                                var listData = listObjects.Select(t => t.Text).ToList();

                                TableSupplier tableSupplier = new TableSupplier();
                                tableSupplier.Insert(listData);
                            }

                            break;
                            #endregion
                        }

                    case "2":
                        {
                            #region TableGames

                            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                             textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                             textBox5.Text == string.Empty || textBox6.Text == string.Empty )
                            {
                                MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                            }
                            else
                            {
                                var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6

                            };
                                var listData = listObjects.Select(t => t.Text).ToList();

                                TableGames tableGames = new TableGames();
                                tableGames.Insert(listData);
                            }

                            break;

                            #endregion
                            
                        }
                    case "3":
                        {
                            #region TableWorkers

                            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                             textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                             textBox5.Text == string.Empty || textBox6.Text == string.Empty ||
                             textBox7.Text == string.Empty || textBox8.Text == string.Empty ||
                             textBox9.Text == string.Empty)
                            {
                                MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                            }
                            else
                            {
                                var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9

                            };
                                var listData = listObjects.Select(t => t.Text).ToList();

                                TableWorkers tableWorkers = new TableWorkers();
                                tableWorkers.Insert(listData);
                            }

                            break;

                            #endregion
                          
                        }
                    case "4":
                        {
                            #region TableClient

                            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                             textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                             textBox5.Text == string.Empty || textBox6.Text == string.Empty ||
                             textBox7.Text == string.Empty || textBox8.Text == string.Empty ||
                             textBox9.Text == string.Empty)
                            {
                                MessageBox.Show(@"Вы заполнили не все поля", @"Ошибка!!!");
                            }
                            else
                            {
                                var listObjects = new List<TextBox>()
                            {
                                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9

                            };
                                var listData = listObjects.Select(t => t.Text).ToList();

                                TableClient tableClient = new TableClient();
                                tableClient.Insert(listData);
                            }

                            break;

                            #endregion
                            
                         }
                    case "5":
                        {
                            #region TableAccessory

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

                                TableAccessory tableAccessory = new TableAccessory();
                                tableAccessory.Insert(listData);
                            }

                            break;

                            #endregion
                            
                        }
                    case "6":
                        {
                            #region TableConnClient

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

                                TableConnClient tableConnClient = new TableConnClient();
                                tableConnClient.Insert(listData);
                            }

                            break;

                            #endregion
                           
                        }
                    
                }
            
        }

        private void cmbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TextBox> listTextBoxs = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9
            };

            foreach (var item in listTextBoxs)
            {
                item.Enabled = true;
                item.Text = string.Empty;
            }
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            var gap = " ";

            if (notyet)
            {
                switch (cmbxTables.Text)
                {
                    case "1":
                    {
                        #region Заголовки табл 1

                        label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 40)) + "Название завода" + String.Concat(Enumerable.Repeat(gap, 15)) + "Ответственное лицо" + String.Concat(Enumerable.Repeat(gap, 10)) + "Телефон" + String.Concat(Enumerable.Repeat(gap, 30)) + "Город";
                        label3.Text = "Улица" + String.Concat(Enumerable.Repeat(gap, 40)) + "Дом" + String.Concat(Enumerable.Repeat(gap, 35)) + "Квартира";
                        textBox9.Enabled = false;
                        break;

                        #endregion
                        
                    }
                    case "2":
                    {
                        #region Заголовки табл 2

                        label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 40)) + "Название игры" + String.Concat(Enumerable.Repeat(gap, 20)) + "Цена" + String.Concat(Enumerable.Repeat(gap, 45)) + "Жанр игры" + String.Concat(Enumerable.Repeat(gap, 25)) + "Кол-во игроков";
                        label3.Text = "Кол-во времени на партию";
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        break;

                        #endregion
                     
                    }
                    case "3":
                    {
                        #region Table 3

                        label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 40)) + "Имя работника" + String.Concat(Enumerable.Repeat(gap, 20)) + "Фамилия работника" + String.Concat(Enumerable.Repeat(gap, 10)) + "Электронная почта" + String.Concat(Enumerable.Repeat(gap, 10)) + "Телефон";
                        label3.Text = "УИД поставки" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД поставщика" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД игры" + String.Concat(Enumerable.Repeat(gap, 25)) + "УИД аксессуара";
                        break;

                        #endregion
                    }
                    case "4":
                    {
                        #region Заголовки Табл4

                        label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 40)) + "Имя" + String.Concat(Enumerable.Repeat(gap, 40)) + "Фамилия" + String.Concat(Enumerable.Repeat(gap, 25)) + "Электронная почта" + String.Concat(Enumerable.Repeat(gap, 25)) + "Страна";
                        label3.Text = "Город" + String.Concat(Enumerable.Repeat(gap, 40)) + "Улица" + String.Concat(Enumerable.Repeat(gap, 40)) + "Дом" + String.Concat(Enumerable.Repeat(gap, 40)) + "Квартира";
                        break;

                        #endregion
                    }
                    case "5":
                    {
                        #region Table 5

                        label2.Text = "УИД" + String.Concat(Enumerable.Repeat(gap, 35)) + "Название акссесуара" + String.Concat(Enumerable.Repeat(gap, 20)) + "Цена";
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        break;

                        #endregion
                    }

                    case "6":
                    {
                        #region TableConnClient

                        label2.Text = "УИД заказа" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД Аксессуара" + String.Concat(Enumerable.Repeat(gap, 20)) + "УИД игры" + String.Concat(Enumerable.Repeat(gap, 30)) + "УИД покупателя" + String.Concat(Enumerable.Repeat(gap, 15)) + "УИД работника";
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        break;
                        #endregion
                    }
                }
            }
        }

        
    }
}
