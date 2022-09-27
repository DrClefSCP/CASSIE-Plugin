using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System.Collections.Generic;

namespace Test1
{
    public class EventHandlers
    {
        private CoroutineHandle coroutine;
        public void OnRoundStarted()
        {
            Timing.CallDelayed(Plugin.Instance.Config.Delay1, () => Cassie.MessageTranslated(Plugin.Instance.Config.CassieMessage1, Plugin.Instance.Config.CassieMessageTranslated1));
            Timing.CallDelayed(Plugin.Instance.Config.Delay2, () => Cassie.MessageTranslated(Plugin.Instance.Config.CassieMessage2, Plugin.Instance.Config.CassieMessageTranslated2));
            coroutine = Timing.RunCoroutine(StartMessages());
        }
        public void RoundEndedEvent(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines(coroutine);
            Cassie.Clear();
        }
        public IEnumerator<float> StartMessages()
        {
            yield return Timing.WaitForSeconds(Plugin.Instance.Config.Delay1);
            Log.Info(Plugin.Instance.Config.CassieMessageTranslated1);
            yield return Timing.WaitForSeconds(Plugin.Instance.Config.Delay2 - Plugin.Instance.Config.Delay1);
            Log.Info(Plugin.Instance.Config.CassieMessageTranslated2);
        }
    }
}
