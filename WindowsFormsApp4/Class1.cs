using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Class1
    {
        public int PublicState;
        private int privateState;
        public Class1(int state)
        {
            PublicState = state;///
            if(PublicState == 0)
            {
                Console.WriteLine($"state={PublicState}");
            }
            else if (PublicState == 1)
            {
                Console.WriteLine($"state={PublicState}");
            }
            else if (PublicState == 2)
            {
                Console.WriteLine($"state={PublicState}");
            }
        }
        public Class1()
        {
        }
        public void PrintState(int state)
        {
            privateState = state;
            if (privateState == 0)
            {
                Console.WriteLine($"state={privateState}");
            }
            else if (privateState == 1)
            {
                Console.WriteLine($"state={privateState}");
            }
            else if (privateState == 2)
            {
                Console.WriteLine($"state={privateState}");
            }
        }
        public void ChangePrivateState(int state)
        {
            privateState=state;
            Console.WriteLine($"state={state}");
        }
    }
}
