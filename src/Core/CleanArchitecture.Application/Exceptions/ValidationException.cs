using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
        public ValidationException():this("Validation exception ocurred")
        {

        }

        public ValidationException(Exception ex):this(ex.Message)
        {

        }

    }
}
