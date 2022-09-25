using Exiled.API.Features;
using MEC;

namespace Test1
{
    public class EventHandlers
    {
        public void OnRoundStarted()
        {
            Timing.CallDelayed(900, () => Cassie.MessageTranslated("The Warhead will be activated in T-Minus 5 Minutes", "La nuke automatica sera activada en 5 minuto"));
            Timing.CallDelayed(1140, () => Cassie.MessageTranslated("The Warhead will be activated in T-Minus 1 Minute", "La nuke automatica sera activada en 1 minuto"));
        }
    }
}
