using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Models
{
    public class Select2DataItemModel
    {
        public Select2DataItemModel()
        {
        }

        public Select2DataItemModel(int id, string text)
        {
            this.id = id;
            this.text = text;
            this.selected = false;
        }

        public int id { get; set; }
        public string text { get; set; }
        public bool selected { get; set; }
    }

    public class Select2DataModel
    {
        public Select2DataModel()
        {
            more = false;
        }

        public IEnumerable<Select2DataItemModel> results { get; set; } 
        public bool more { get; set; }
    }
}
