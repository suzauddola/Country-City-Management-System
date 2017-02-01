using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { set; get; }
        public object Data { set; get; }
        public string Message { set; get; }

        public ResponseModel(bool isSuccess = true, object data = null, string message = "Success")
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
        }
    }
}