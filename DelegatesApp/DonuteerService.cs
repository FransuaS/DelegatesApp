using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DelegatesApp
{
    class DonuteerService
    {
        public void DonuteerWorker(Order o, EventArgs e)
        {
            MessageBox.Show("Making Donuts");
        }
    }
}
