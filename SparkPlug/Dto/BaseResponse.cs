using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Dto
{
    public class BaseResponse<T>
    {
        public Boolean Success { get; set; }
        public String Message { get; set; }
        public T Result { get; set; }
    }
}
