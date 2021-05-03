using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int coffee = Convert.ToInt32(textBox2.Text);
            int donuts = Convert.ToInt32(textBox3.Text);

            Order o = new Order(name, coffee, donuts);
            ProcessOrder processingOrder = new ProcessOrder();

            //MessageBox.Show(o.calculate().ToString());

            CashierService c = new CashierService();
            DonuteerService d = new DonuteerService();

            processingOrder.ProcessedOrder += c.CashierWorker;
            processingOrder.ProcessedOrder += d.DonuteerWorker;

            processingOrder.Process(o);
        }
    }
}
