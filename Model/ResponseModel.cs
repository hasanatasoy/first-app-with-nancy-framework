using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_meet_with_nancy_framework.Model
{
    class ResponseModel<T>
    {
        public T result { get; set; }
        public int httpStatusCode { get; set; }

        public ResponseModel(T result, int statusCode)
        {
            this.result = result;
            httpStatusCode = statusCode;
        }
    }
}
