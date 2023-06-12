using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DOM
{
    public class BaseDOM
    {
        public string? message { get; set; }=String.Empty;
        public Int32? code { get; set; }=Int32.MaxValue;
    }
}
