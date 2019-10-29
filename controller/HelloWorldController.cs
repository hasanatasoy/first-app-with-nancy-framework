using first_meet_with_nancy_framework.Model;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_meet_with_nancy_framework.controller
{
    public class HelloWorldController : NancyModule
    {

        public HelloWorldController()
        {
            Get("/helloworld", parameters => "Hello World!");
            Post("/sum", parameters =>
            {
                var requestModel = this.Bind<RequestModel>();
                return new ResponseModel<int>(requestModel.sum1 + requestModel.sum2, 200);
            });
            Get("/sum/{sum1}/{sum2}", parameters =>
            {
                int sum1 = parameters.sum1;
                int sum2 = parameters.sum2;
                return new ResponseModel<int>(sum1+sum2, 200);
            });
        }
    }
}
