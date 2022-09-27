using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Test1
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Lo que dice el primer mensaje de el C.A.S.S.I.E")]
        public string CassieMessage1 { get; set; } = "The Warhead will be activated in T-Minus 5 Minutes";

        [Description("Lo que escribe el primer mensaje de el C.A.S.S.I.E")]
        public string CassieMessageTranslated1 { get; set; } = "La nuke sera activada en 5 minutos";

        [Description("El delay que tiene el primer mensaje de el C.A.S.S.I.E (15 mins por defecto)")]
        public float Delay1 { get; set; } = 900f;

        [Description("Lo que dice el segundo mensaje de el C.A.S.S.I.E")]
        public string CassieMessage2 { get; set; } = "The Warhead will be activated in T-Minus 1 Minutes";

        [Description("Lo que escribe el segundo mensaje de el C.A.S.S.I.E")]
        public string CassieMessageTranslated2 { get; set; } = "La nuke sera activada en 1 minuto";

        [Description("El delay que tiene el segundo mensaje de el C.A.S.S.I.E (19 mins por defecto)")]
        public float Delay2 { get; set; } = 1440f;

    }
}
