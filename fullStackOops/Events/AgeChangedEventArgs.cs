using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    public class AgeChangedEventArgs : EventArgs
    {
        public int OldAge { get; set; }
        public int NewAge { get; set; }

        public AgeChangedEventArgs(int oldAge, int newAge)
        {
            OldAge = oldAge;
            NewAge = newAge;
        }

       
    }
}
