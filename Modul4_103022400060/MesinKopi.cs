using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400060
{
    public class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE }
        public enum Trigger { POWER_ON, POWER_OFF, START_BREW, FINISH_BREW, START_MAINTENANCE, FINISH_MAINTENANCE }

        public State currentState = State.OFF;

        public void UbahState(Trigger trigger)
        {
            State nextState = currentState;
            string pesanPeralihan = "Perubahan tidak valid";

            switch (currentState)
            {
                case State.OFF:
                    if (trigger == Trigger.POWER_ON)
                    {
                        nextState = State.STANDBY;
                        pesanPeralihan = "Mesin off berubah menjadi standby";

                    }
                    break;
                case State.STANDBY:
                    if (trigger == Trigger.START_BREW)
                    {
                        nextState = State.BREWING;
                        pesanPeralihan = "Mesin standby berubah menjadi brewing";
                    }
                    else if (trigger == Trigger.START_MAINTENANCE)
                    {
                        nextState = State.MAINTENANCE;
                        pesanPeralihan = "Mesin standby berubah menjadi maintenance";
                    }
                    else if (trigger == Trigger.POWER_OFF)
                    {
                        nextState = State.OFF;
                        pesanPeralihan = "Mesin standby berubah menjadi off";
                    }
                    break;
                case State.BREWING:
                    if (trigger == Trigger.FINISH_BREW)
                    {
                        nextState = State.STANDBY;
                        pesanPeralihan = "Mesin brewing berubah menjadi standby";

                    }
                    break;
                case State.MAINTENANCE:
                    if (trigger == Trigger.FINISH_MAINTENANCE)
                    {
                        nextState = State.STANDBY;
                        pesanPeralihan = "Mesin maintenance berubah menjadi standby";

                    }
                    break;
            }
            if (nextState != currentState)
            {
                currentState = nextState;
                Console.WriteLine(pesanPeralihan);
            }
            else
            {
                Console.WriteLine(pesanPeralihan);
            }
        }

    }
}
