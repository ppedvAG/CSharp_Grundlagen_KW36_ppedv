using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul013Demo
{


    public delegate void ChangePercentValueDelegate(int newPercentValue);
    public delegate void ResultDelegate(string msg);

    public class BusinessComponentA
    {
        public event ChangePercentValueDelegate ChangePercentValueDelegae;
        public event ResultDelegate ResultDelegate;

        public void Process()
        {
            for (int i = 0; i < 100; i++)
            {
                //wir wollen nach außen mitteilen, welcher Prozentwert aktuell ist. 

                //Wenn ein evet Delegate != null ist, verwendet das Delegate eine Methode
                if (ChangePercentValueDelegae != null)
                    ChangePercentValueDelegae(i);
            }


            //wir wollen nach außen mitteilen, wann wir mit fertig sind. 

            if (ResultDelegate != null)
                ResultDelegate("fertig");
        }
    }
}
