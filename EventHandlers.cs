using Exiled.API.Features;
using MEC;

namespace Test1
{
    public class EventHandlers
    {
        public void OnRoundStarted()
        {
            Timing.CallDelayed(Plugin.Instance.Config.Delay1, () => Cassie.MessageTranslated(Plugin.Instance.Config.CassieMessage1, Plugin.Instance.Config.CassieMessageTranslated1));
            Timing.CallDelayed(Plugin.Instance.Config.Delay2, () => Cassie.MessageTranslated(Plugin.Instance.Config.CassieMessage2, Plugin.Instance.Config.CassieMessageTranslated2));
        }
    }
}
