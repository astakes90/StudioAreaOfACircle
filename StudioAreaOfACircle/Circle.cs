using System;
namespace StudioAreaOfACircle
{
    public class Circle
    {

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CircumferenceOfCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double DiameterOfCircle(double radius)
        {
            return 2 * radius;
        }

        public static double TotalGallonsForTrip(double circumference, double milesPerGallon)
        {
            return circumference / milesPerGallon;
        }

    }
}