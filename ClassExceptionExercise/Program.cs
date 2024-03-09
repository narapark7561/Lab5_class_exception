using ClassExceptionExercise;

namespace ClassExceptionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();

            // Test with a negative radius
            try
            {
                myCircle.SetRadius(-5);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Invalid radius: {ex.Message}");
            }

            // Test with a positive radius
            try
            {
                myCircle.SetRadius(10);
                Console.WriteLine($"Successfully set radius: {myCircle.Radius}");
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Invalid radius: {ex.Message}");
            }

            // Test with a radius of zero
            try
            {
                myCircle.SetRadius(0);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Invalid radius: {ex.Message}");
            }
        }
    }
}


















/*
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        try
        {
            myCircle.SetRadius(-5); // This will throw an exception
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Invalid radius: {ex.Message}");
        }
    }
}
*/