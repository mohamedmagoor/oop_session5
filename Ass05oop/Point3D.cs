using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass05oop
{

    #region project one...

   
    internal class Point3D : ICloneable, IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);

        }

       

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point3D p = (Point3D)obj;
            return X == p.X && Y == p.Y && Z == p.Z;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null))
                return ReferenceEquals(p2, null);

            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
        private static Point3D ReadPointFromUser(string pointName)
        {
            Console.WriteLine($"Enter coordinates for {pointName}:");
            int x = ReadIntFromUser("X");
            int y = ReadIntFromUser("Y");
            int z = ReadIntFromUser("Z");
            return new Point3D(x, y, z);
        }
        private static int ReadIntFromUser(string coordinateName)
        {
            while (true)
            {
                Console.Write($"{coordinateName}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

}
