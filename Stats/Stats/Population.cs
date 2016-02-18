using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stats
{
    class Population
    {
        private List<String> RowNames = new List<string>();
        private List<List<String>> DataRows = new List<List<string>>();

        Population()
        {

        }

        void Add(List<String> dataRow)
        {
            DataRows.Add(dataRow);
        }
    }
}
