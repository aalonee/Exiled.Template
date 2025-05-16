using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exiled.Template
{
    public class EventHandlers
    {
        private Plugin _instance;

        public EventHandlers(Plugin instance)
        {
            _instance = instance;
        }

        ~EventHandlers()
        {

        }
    }
}
