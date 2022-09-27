using System;
using Exiled.API.Features;


namespace Test1
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public EventHandlers handler;

         public override void OnEnabled()
        {
            Instance = this;
            handler = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += handler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded += handler.RoundEndedEvent;
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= handler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded -= handler.RoundEndedEvent;
            handler = null;
            Instance = null;
        }
    }
}
