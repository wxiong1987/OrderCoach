using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attentio.Infrastructure.Models
{
    public class DataRangeModel
    {
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }
        /// <summary>
        /// For pie chart only
        /// </summary>
        public int Limit { get; set; }
    }
}