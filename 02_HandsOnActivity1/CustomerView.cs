using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HandsOnActivity1
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                lblQueue.Text = CashierClass.CashierQueue.Peek();
            }
            catch (InvalidOperationException ie)
            {
                MessageBox.Show(ie.Message);
                this.Close();
            }
        }
    }
}
