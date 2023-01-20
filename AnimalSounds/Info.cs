using Kids1135PluginBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AnimalSounds
{
    public class Info : IPlugin
    {
        public string Name => "Звуки животных";

        public string Description => "Познай как выглядят животные и какие звуки они издают))";

        public string Author => "Кокорин А.В";

        public Page GetPage()
        {
            return new MainPage();
        }
    }
}
