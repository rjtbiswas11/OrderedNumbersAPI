using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderedNumbersAPI
{
    public class SaveSortedNumbersRequest
    {
        public int[] ArrayToSort { get; set; }
        public string FileName { get; set; }
    }
}
