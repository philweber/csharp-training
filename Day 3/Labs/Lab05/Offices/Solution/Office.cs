using System;

namespace Offices
{
	public class Office
	{
		public uint Size;
		public uint Building;
		public uint Room;

        public override int GetHashCode()
        {
            // Room numbers are no larger than 4 digits,
            // so multiply building number by 10000, then
            // add room number to generate unique ID
            return (int)(Building * 10000 + Room);
        }

		public override string ToString()
		{
			return string.Concat(Building, "/", Room);
		}

		public override bool Equals (object obj)
		{
            if (obj is Office)
            {
                Office o = (Office)obj;
                return (this.GetHashCode() == o.GetHashCode());
            }
            else
            {
                return false;
            }

		}

        static public bool operator ==(Office o1, Office o2)
        {
            return Equals(o1, o2);
        }

        static public bool operator !=(Office o1, Office o2)
        {
            return !Equals(o1, o2);
        }

        public static implicit operator OfficeUnit(Office o)
        {
            return new OfficeUnit(o);
        }
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