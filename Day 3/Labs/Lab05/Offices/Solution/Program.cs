using System;

namespace Offices
{
	class Program
	{
		static void Main(string[] args)
		{
            // Declare two Office variables, o1 and o2
            // Specify values for each Office's Building,
            // Room, and Size

            Office o1 = new Office();
			o1.Building = 4;
			o1.Room = 432;
			o1.Size = 100;

			Office o2 = new Office();
            o2.Building = 4;
			o2.Room = 432;
			o2.Size = 100;

            // Print each Office to the screen
            Console.WriteLine("o1 string = {0}, o2 string = {1}", o1, o2);

            // Print each Office's hash code
            Console.WriteLine("o1 hash = {0}, o2 hash = {1}", o1.GetHashCode(), o2.GetHashCode());

            // Compare the two Offices and print whether 
            // or not they are equal
            Console.WriteLine("o1 == o2: " + (o1 == o2));

            // Convert o1 to an OfficeUnit
            OfficeUnit ou = o1;

            // Print the properties of the OfficeUnit
            Console.WriteLine(" Building Number: {0}", ou.Building);
			Console.WriteLine("     Room Number: {0}", ou.Room);
			Console.WriteLine("Office Unit Size: {0}", ou.Size);
		}
	}
}
