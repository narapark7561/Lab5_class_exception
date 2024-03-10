using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptionExercise
{
    public class InvalidRadiusException : Exception
    {
        // No argument constructor with a default message
        public InvalidRadiusException()
            : base("Radius is less than or equal to zero.") { }

        // Constructor that accepts a specific radius value and provides a message
        public InvalidRadiusException(double radius)
            : base($"Radius value {radius} is not valid. It must be greater than zero.") { }


        // Additional constructors can remain unchanged as they are not specified in the requirement.
        public InvalidRadiusException(string message) : base(message) { }

        public InvalidRadiusException(string message, Exception inner) : base(message, inner) { }
    }
}