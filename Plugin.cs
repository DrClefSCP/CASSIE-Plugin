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
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= handler.OnRoundStarted;
            handler = null;
            Instance = null;
        }
    }
}
