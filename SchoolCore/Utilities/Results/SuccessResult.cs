using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolCore.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult (string message): base(success:true, message)
        {
        }
        public SuccessResult (): base(success:true)
        {
        }
    }
}
