using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalGit
{
    public partial class HelloGit : Form
    {
        public HelloGit()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello world of Git");
            
        }
    }
}
