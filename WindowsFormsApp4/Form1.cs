using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 class1 = new Class1();
            class1.PublicState = 2;
            //class1.privateState = 2;
            class1.ChangePrivateState(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*12132123132132132*/
        }
    }
}
