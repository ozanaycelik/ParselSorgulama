using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParselSorgulama.Models
{
    public class ServiceResult
    {
        public bool status_ { get; set; }
        public object exceptionMessage { get; set; }
        public object result { get; set; }
    }
}
