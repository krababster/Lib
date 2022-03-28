using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = ".*txt|*.TXT|.*doc|*.DOC|*.*|*ALL";
                ofd.Title = "choose file dest";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Form2 form2 = new Form2();
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
