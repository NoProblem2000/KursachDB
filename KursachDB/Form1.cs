using System.Windows.Forms;

namespace KursachDB
{
    public partial class Form1 : Form
    {
        Select frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, System.EventArgs e)
        {
            if (frm2 == null)
            {

                frm2 = new Select();
                frm2.Show();
            }
            else
                frm2.Activate();
        }

        private void InsertBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
