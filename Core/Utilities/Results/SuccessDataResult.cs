using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success) : base(data, success)
        {
        }

        public SuccessDataResult(T data): base(data, success: true)
        {
        }

    }
}
