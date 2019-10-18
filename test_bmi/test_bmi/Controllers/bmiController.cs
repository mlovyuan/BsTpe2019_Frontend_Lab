using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace test_bmi.Controllers
{
    public class bmiController : ApiController
    {
        public class BMIResult
        {
            public float BMI { get; set; }
        }

        public class BMIParam
        {
            //要跟前端傳來的參數名字一樣
            public float height { get; set; }
            public float weight { get; set; }
        }

        public class BMIController : ApiController
        {
            [HttpPost]
            public IHttpActionResult Post(BMIParam para)
            {
                
                para.height = para.height / 100;
                var bmi = para.weight / (para.height * para.height);
                var ret = new BMIResult() { BMI = bmi };
                return Ok(ret);
            }
        }
    }
}
