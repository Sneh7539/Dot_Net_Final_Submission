using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            float currentSize = lblFont.Font.Size;
            lblFont.Font = new Font("Courier New", currentSize - 5);
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            float currentSize = lblFont.Font.Size;
            lblFont.Font = new Font("Courier New", currentSize + 5);
        }

        private void lblFont_Click(object sender, EventArgs e)
        {
            
        }
    }
}