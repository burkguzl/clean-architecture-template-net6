using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public ServiceResponse(T value, bool isSuccess, string message)
        {
            Data = value;
            IsSuccess = isSuccess;
            Message = message;
        }

        public ServiceResponse(T value, bool isSuccess)
        {
            Data = value;
            IsSuccess = isSuccess;
        }
    }
}
