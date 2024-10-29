using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstTask
{
    public partial class Form2 : Form
    {
        private Form _form = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form)
        {
            InitializeComponent();
            form.BackColor=Color.Aqua;
            _form = form;
        }
        
    }
}
