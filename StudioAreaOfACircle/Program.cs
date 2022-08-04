using StudioAreaOfACircle;

Circle circle = new Circle();

Console.WriteLine("Enter a radius: ");

string userInput = Console.ReadLine();

double radius = double.Parse(userInput);

while (radius <= 1)
{
    Console.WriteLine("Enter a valid radius: ");
    radius = double.Parse(Console.ReadLine());
}

Console.WriteLine($"The area of a circle of radius {radius} is: {Circle.AreaOfCircle(radius)}");

Console.WriteLine($"The circumference of a circle of radius {radius} is: {Circle.CircumferenceOfCircle(radius)}");

Console.WriteLine($"The diameter of a circle of radius {radius} is: {Circle.DiameterOfCircle(radius)}");

Console.WriteLine("Enter your miles per gallon: ");

string userInput2 = Console.ReadLine();

double milesPerGallon = double.Parse(userInput2);

Console.WriteLine($"It will take {Circle.TotalGallonsForTrip(Circle.CircumferenceOfCircle(radius), milesPerGallon)} to get around the circle.");