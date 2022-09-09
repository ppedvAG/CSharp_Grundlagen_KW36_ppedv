using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul013Demo
{
    public class BusinessComponentB
    {
        public event EventHandler PercentValueChanged;
        public event EventHandler ProcessCompleted;



        //Verbesserung zu PercentValueChanged und ProcessCompleted
        public event EventHandler<PercentEventArgs> PercentValueChanged2;
        public event EventHandler<FinishEventArgs> ProcessCompleted2;

        public BusinessComponentB()
        {

        }

        public void Process()
        {
            for(int i = 0; i < 100; i++)
            {
                if (PercentValueChanged != null)
                    PercentValueChanged.Invoke(this, new PercentEventArgs() { PercentValue = i});

                if (PercentValueChanged2 != null)
                    PercentValueChanged2.Invoke(this, new PercentEventArgs() { PercentValue = i });
            }

            if (ProcessCompleted != null)
                ProcessCompleted.Invoke(this, new FinishEventArgs() { Message = "Komponente ist mit Process fertig" });
        
            if (ProcessCompleted2 != null)
                ProcessCompleted2.Invoke(this, new FinishEventArgs() { Message = "Komponente ist mit Process fertig" });

        }
    }


    public class PercentEventArgs : EventArgs
    {
        public int PercentValue { get; set; }
    }

    public class FinishEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
