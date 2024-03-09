using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptionExercise
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() { }

        public InvalidRadiusException(string message) : base(message) { }

        public InvalidRadiusException(double radius)
            : base($"Radius value {radius} is not valid. It must be greater than zero.")
        {
        }

        public InvalidRadiusException(string message, Exception inner) : base(message, inner) { }
    }
}
