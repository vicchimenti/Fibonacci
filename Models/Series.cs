using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci.Models
{
    public class Series
    {
        public int ID { get; set; }
        public int Position { get; set; }
        public long Result { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OperationTime { get; set; }
    }
}
