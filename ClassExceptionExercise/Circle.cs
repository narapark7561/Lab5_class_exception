using ClassExceptionExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptionExercise
{
    public class Circle
    {
        // Private field to hold the radius of the circle
        private double _radius;


        public double Radius
        {
            get { return _radius; }
        }

        // Public method to set the radius of the circle
        // This method includes validation to ensure the radius is positive
        public void SetRadius(double newRadius)
        {
            // If the new radius is greater than zero, update the _radius field
            if (newRadius > 0)
            {
                _radius = newRadius;
            }
            // If the new radius is exactly zero, throw an InvalidRadiusException with a specific message
            else if (newRadius == 0)
            {
                throw new InvalidRadiusException("Radius is must be not equal with zero");

            }  // If the new radius is less than zero, also throw an InvalidRadiusException with a different message
            else
            {
                throw new InvalidRadiusException("Radius is must greater then zero");
            }
        }

        public override string ToString()
        {
            // Return a string representation of the circle
            // Including the type of object and the value of its radius
            return $"Circle with radius: {_radius}";
        }
    }
}

