using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class khoamay : Form
    {
        public khoamay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (label2.Left <= this.Width)
            {
                label2.Left = label2.Left + 10;
            }
            else
                label2.Left = -label2.Width;
        }
    }
}
