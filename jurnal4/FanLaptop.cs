using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal4
{
    class FanLaptop
    {
        private enum State { BALANCED, QUIET,TURBO,PERFORMANCE }
        private State currentState;

        public FanLaptop()
        {
            currentState = State.BALANCED;
            Console.WriteLine("FAN BALANCED");
        }

        public void FanQuiet()
        {
            if (currentState == State.TURBO)
            {
                currentState = State.QUIET;
                Console.WriteLine("Kipas Menjadi mode quiet");
            }
            else if(currentState == State.BALANCED)
            {
                currentState = State.QUIET;
                Console.WriteLine("Kipas Menjadi mode quiet");
            }
            else
            {
                Console.WriteLine("Kipas sudah mode quiet");
            }
        }

        public void FanBalanced()
        {
            if (currentState == State.QUIET)
            {
                currentState = State.BALANCED;
                Console.WriteLine("Kipas menjadi mode balanced");
            }
            else if(currentState == State.PERFORMANCE)
            {
                currentState = State.BALANCED;
                Console.WriteLine("Kipas menjadi mode balanced");
            }
            else
            {
                Console.WriteLine("Kipas sudah mode Balanced");
            }
        }
        public void FanTurbo()
        {
            if (currentState == State.QUIET)
            {
                currentState = State.TURBO;
                Console.WriteLine("Kipas menjadi mode turbo");
            }
            else if (currentState == State.PERFORMANCE)
            {
                currentState = State.TURBO;
                Console.WriteLine("Kipas menjadi mode turbo");
            }
            else
            {
                Console.WriteLine("Kipas sudah mode turbo");
            }
        }
        public void FanPerformanced()
        {
            if (currentState == State.TURBO)
            {
                currentState = State.PERFORMANCE;
                Console.WriteLine("Kipas menjadi mode performance");
            }
            else if (currentState == State.BALANCED)
            {
                currentState = State.PERFORMANCE;
                Console.WriteLine("Kipas menjadi mode performance");
            }
            else
            {
                Console.WriteLine("Kipas sudah mode performance");
            }
        }
    }
}
