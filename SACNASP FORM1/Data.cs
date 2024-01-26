using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACNASP_FORM1
{
    public partial class _2019 : Form
    {
        public _2019()
        {
            InitializeComponent();

        }

        private void _2019_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //panel1.Hide();
            panel4.Show();
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            
            panel4.Hide();
            //panel1.Hide();    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
