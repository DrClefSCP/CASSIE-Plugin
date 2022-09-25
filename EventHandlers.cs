using Exiled.API.Features;
using MEC;

namespace Test1
{
    public class EventHandlers
    {
        public void OnRoundStarted()
        {
            Timing.CallDelayed(delay, () => Cassie.MessageTranslated("What the CASSIE will say", "What the CASSIE will write down"));
        }
    }
}

//Change the delay measured in seconds so the CASSIE appears when you want it to (example: 15 mins = 900 secs).
