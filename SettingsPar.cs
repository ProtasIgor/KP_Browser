using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    internal class SettingsPar
    {
        public string searchEngine {  get; set; }

        public string searchDefaultPage { get; set; }

        public bool saveHistory {  get; set; }

        public bool saveDate { get; set; }

        public string saveTypeHistory { get; set; }
    }
}
