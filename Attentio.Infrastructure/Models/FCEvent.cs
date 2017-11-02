using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Models
{
    public class FCEvent
    {
        public int id { get; set; }
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string url { get; set; }
        public string tooltip { get; set; }
    }
}
