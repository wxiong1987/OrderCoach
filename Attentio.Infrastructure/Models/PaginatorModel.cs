using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Models
{
    public class PaginatorModel
    {
        public static int DefaultPage = 1;
        public static int DefaultPageSize = 12;

        public PaginatorModel()
        {
        }

        public PaginatorModel(int total)
        {
            PageSize = DefaultPageSize;
            Page = DefaultPage;
            Total = total;
            PageCount = total/PageSize + ((total > PageSize) ? total%PageSize : 1);
        }

        public int PageSize { get; set; }
        public int Page { get; set; }
        public int PageCount { get; set; }
        public int Total { get; set; }
    }
}
