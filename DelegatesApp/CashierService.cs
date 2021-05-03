using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DelegatesApp
{
    class CashierService
    {
        public void CashierWorker(Order o, EventArgs e)
        {
            MessageBox.Show("Collect cash");
        }
    }
}