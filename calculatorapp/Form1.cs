using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorapp
{
    
    public partial class frmCal : Form
    {
        Double Total=0;
        string oprtor="";
        bool isOperation = false;
        public frmCal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                txtCal.Clear();
            }
            isOperation = false;
            Button btn = (Button)sender;
            txtCal.Text = txtCal.Text + btn.Text;

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            oprtor = btn.Text;
            Total = Convert.ToDouble(txtCal.Text);
            isOperation = true;

        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (oprtor)
            {
                case "+":
                    txtCal.Text = (Total + Convert.ToDouble(txtCal.Text)).ToString();
                    break;

                case "-":
                    txtCal.Text = (Total - Convert.ToDouble(txtCal.Text)).ToString();
                    break;

                case "*":
                    txtCal.Text = (Total * Convert.ToDouble(txtCal.Text)).ToString();
                    break;

                case "/":
                    txtCal.Text = (Total / Convert.ToDouble(txtCal.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
            Total = 0;
        }
    }
}
