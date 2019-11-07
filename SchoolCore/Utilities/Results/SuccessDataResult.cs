using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolCore.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data,success: true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, success: true)
        {
        }
        public SuccessDataResult(string message) : base(default, success: true)
        {

        }
        public SuccessDataResult() : base(default, success: true)
        {
        }
    }
}
