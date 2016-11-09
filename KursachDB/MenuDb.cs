using System.Windows.Forms;

namespace KursachDB
{
    public partial class Form1 : Form
    {
        Select frm2;
        Insert frm3;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, System.EventArgs e)
        {
             frm2 = new Select();
             frm2.Show();
        }

        private void InsertBtn_Click(object sender, System.EventArgs e)
        {
           frm3 = new Insert();
           frm3.Show();
        }

        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
