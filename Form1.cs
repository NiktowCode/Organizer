using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void Close_Window(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}