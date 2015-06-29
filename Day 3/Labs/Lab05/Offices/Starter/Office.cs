using System;

namespace Offices
{
	public struct Office
	{
		public uint Size;
		public uint Building;
		public uint Room;

        // Override the GetHashCode method. Use the 
        // following algorithm to generate a hash code:
        // HashCode = Building * 10000 + Room 
        public override int GetHashCode()
        {
            return (int)((Building * 10000) + Room);
        }

        // Override the ToString method. Return 
        // a string containing the building and room 
        // numbers separated by a forward slash

        // Override the Equals method. Cast the object 
        // parameter to a variable of type Office. 
        // Compare the Office's building, room, and size
        // values to the values of this object. If they 
        // are equal, return true; otherwise return false.

        // Advanced: Overload the == and != operators

        // Advanced: Implement an explicit conversion
        // from Office to OfficeUnit
	}

    public enum OfficeSizes
    {
        Small,
        Medium,
        Large
    }

    public struct OfficeUnit
	{
		public OfficeSizes Size;
		public uint Building;
		public uint Room;

		public OfficeUnit(Office o)
		{
            // Convert Office size to OfficeSizes enum
			if (o.Size <= 64) 
            {
                this.Size = OfficeSizes.Small;
            }
            else if (o.Size > 64 && o.Size < 100)
            {
                this.Size = OfficeSizes.Medium;
            }
            else
            {
                this.Size = OfficeSizes.Large;
            }

            this.Building = o.Building;
			this.Room = o.Room;
		}
	}
}