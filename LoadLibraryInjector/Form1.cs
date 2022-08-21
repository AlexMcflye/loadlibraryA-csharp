using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadLibraryInjector
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

        private void button1_Click(object sender, EventArgs e)
        {
            string pr0cessname, dllpath;
            pr0cessname = textBox1.Text;
            dllpath = textBox2.Text;
            LoadLibraryInjector.LoadLibraryCS.Inject(pr0cessname,dllpath);
        }
    }
}
