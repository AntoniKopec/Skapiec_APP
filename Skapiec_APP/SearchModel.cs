using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapiec_APP
{
    class SearchModel
    {
        public string SearchQuery { get; set; }

        public string SearchCombo
        {
            get
            {
                return $"{SearchQuery}";
            }
        }
    }
}
