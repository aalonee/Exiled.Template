using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Template.Configs;
using System;

namespace Exiled.Template
{
    public class Plugin : Plugin<Config, Translation>
    {
        public override string Name => "";
        public override string Prefix => "";
        public override string Author => "";
        public override Version Version => new(1, 0, 0);
        public override PluginPriority Priority => PluginPriority.Default;

        public Plugin Instance { get; private set; }
        public EventHandlers EventHandlers { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            EventHandlers = new(Instance);

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            EventHandlers = null;
            Instance = null;

            base.OnDisabled();
        }
    }
}
