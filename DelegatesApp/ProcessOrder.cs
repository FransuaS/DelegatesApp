using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesApp
{
    class ProcessOrder
    {
        public delegate void ProcessOrderEventHandler(Order source, EventArgs e);

        public event ProcessOrderEventHandler ProcessedOrder;

        public void Process(Order o)
        {
            OnProcessedOrder(o);
        }

        public virtual void OnProcessedOrder(Order o)
        {
            if (ProcessedOrder != null)
            {
                ProcessedOrder(o, EventArgs.Empty);
            }
        }
    }
}
