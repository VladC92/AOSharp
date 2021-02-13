﻿using System;
using System.Runtime.InteropServices;
using SmokeLounge.AOtomation.Messaging.Serialization.MappingAttributes;

namespace AOSharp.Common.GameData
{
    [StructLayout(LayoutKind.Sequential, Size=0xC)]
    public struct Vector3
    {
        public const float ZeroTolerance = 1e-6f;

        [AoMember(0)]
        public float X { get; set; }

        [AoMember(1)]
        public float Y { get; set; }

        [AoMember(2)]
        public float Z { get; set; }

        public static readonly Vector3 Zero = new Vector3(0, 0, 0);
        public static readonly Vector3 Forward = new Vector3(0, 0, 1);
        public static readonly Vector3 Right = new Vector3(1, 0, 0);
        public static readonly Vector3 Up = new Vector3(0, 1, 0);

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(double x, double y, double z)
        {
            X = (float)x;
            Y = (float)y;
            Z = (float)z;
        }

        public Vector3(double x, double y)
        {
            X = (float)x;
            Y = (float)y;
            Z = 0;
        }

        public double Magnitude
        {
            get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", value,
                                                          "The magnitude of a Vector must be positive or 0.");
                }
                else if (Magnitude == 0)
                {
                    throw new DivideByZeroException("Can not set the magnitude of a Vector with no direction");
                }
                else
                {
                    double factor = value / Magnitude;
                    X = (float)(X * factor);
                    Y = (float)(Y * factor);
                    Z = (float)(Z * factor);
                }
            }
        }

        public static float Angle(Vector3 from, Vector3 to)
        {
            return (float)Math.Acos(Vector3.Dot(from.Normalize(), to.Normalize())) * 57.29578f;
        }

        public static float Distance(Vector3 from, Vector3 to)
        {
            return (float)Math.Sqrt(Math.Pow(Math.Abs(from.X - to.X), 2) + Math.Pow(Math.Abs(from.Y - to.Y), 2) + Math.Pow(Math.Abs(from.Z - to.Z), 2));
        }

        public float DistanceFrom(Vector3 pos)
        {
            return (float)Math.Sqrt(Math.Pow(Math.Abs(X - pos.X), 2) + Math.Pow(Math.Abs(Y - pos.Y), 2) + Math.Pow(Math.Abs(Z - pos.Z), 2));
        }

        public float Distance2DFrom(Vector3 pos)
        {
            return (float)Math.Sqrt(Math.Pow(Math.Abs(X - pos.X), 2) + Math.Pow(Math.Abs(Z - pos.Z), 2));
        }

        public Vector3 Translate(Vector2 vec)
        {
            return new Vector3(X + vec.X, Y, Z + vec.Y);
        }

        public static Vector3 Rotate(Vector3 pivot, Vector3 localPos, float angle)
        {
            localPos.X -= pivot.X;
            localPos.Z -= pivot.Z;
            float dist = (float)Math.Sqrt(localPos.X * localPos.X + localPos.Z * localPos.Z);

            double ca = Math.Atan2(localPos.Z, localPos.X) * 180 / Math.PI;
            double na = ((ca + (360 - angle)) % 360) * Math.PI / 180;

            Vector3 newVertexPos = new Vector3(0, localPos.Y, 0);
            newVertexPos.X = (pivot.X + dist * (float)Math.Cos(na));
            newVertexPos.Z = (pivot.Z + dist * (float)Math.Sin(na));

            return newVertexPos;
        }

        public Vector3 PointOnLine(Vector3 start, Vector3 end)
        {
            Vector3 lineDelta = end - start;
            Vector3 pointDelta = this - start;
            float lineSquareLength = lineDelta.LengthSquared();
            float dot = (float)lineDelta.Dot(pointDelta);
            float percent = dot / lineSquareLength;

            if (percent < 0f || percent > 1f)
                return Zero;

            return start + (lineDelta * percent);
        }

        public Vector3 Randomize(float magnitude)
        {
            Random rnd = new Random();
            return this + new Vector3(rnd.Next((int)-magnitude, (int)magnitude), 0, rnd.Next((int)-magnitude, (int)magnitude));
        }

        public float Length()
        {
            return (float)Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

        public float LengthSquared()
        {
            return (X * X) + (Y * Y) + (Z * Z);
        }


        /// <summary>
        /// Returns the Absolute value of the Vector
        /// </summary>
        /// <param name="v1">Vector</param>
        public static double Abs(Vector3 v1)
        {
            return v1.Magnitude;
        }

        /// <summary>
        /// Returns the Absolute value of the Vector
        /// </summary>
        public double Abs()
        {
            return Magnitude;
        }

        /// <summary>
        /// Returns true if the Vector is a Unit Vector (ie, is of magnitude 1)
        /// </summary>
        /// <param name="v1">Vector</param>
        public static bool IsUnitVector(Vector3 v1)
        {
            return Math.Abs(v1.Magnitude - 1) <= double.Epsilon;
        }

        /// <summary>
        /// Returns true if the Vector is a Unit Vector (ie, is of magnitude 1)
        /// </summary>
        public bool IsUnitVector()
        {
            return IsUnitVector(this);
        }

        /// <summary>
        /// Returns the Normalized Vector
        /// </summary>
        /// <param name="v1">Vector</param>
        public static Vector3 Normalize(Vector3 v1)
        {
            if (v1.Magnitude == 0)
            {
                throw new DivideByZeroException("Can not normalize a Vector with no direction");
            }
            else
            {
                Vector3 UnitVector = v1;

                UnitVector.Magnitude = 1;

                return UnitVector;
            }
        }

        /// <summary>
        /// Returns the Normalized Vector
        /// </summary>
        public Vector3 Normalize()
        {
            return Normalize(this);
        }

        /// <summary>
        /// Returns the Cross Product of two Vectors
        /// </summary>
        /// <param name="vLeft">Vector 1</param>
        /// <param name="vRight">Vector 2</param>
        public static Vector3 Cross(Vector3 vLeft, Vector3 vRight)
        {
            return new Vector3(vLeft.Y * vRight.Z - vLeft.Z * vRight.Y, vLeft.Z * vRight.X - vLeft.X * vRight.Z,
                               vLeft.X * vRight.Y - vLeft.Y * vRight.X);
        }

        /// <summary>
        /// Returns the Cross Product of two Vectors
        /// </summary>
        /// <param name="vRight">Other Vector</param>
        public Vector3 Cross(Vector3 vRight)
        {
            return Cross(this, vRight);
        }

        /// <summary>
        /// Returns the Dot Product of two Vectors
        /// </summary>
        /// <param name="v1">Vector 1</param>
        /// <param name="v2">Vector 2</param>
        public static double Dot(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Returns the Dot Product of two Vectors
        /// </summary>
        /// <param name="v1">Other Vector</param>
        public double Dot(Vector3 v1)
        {
            return Dot(this, v1);
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }

        public Vector2 ToVector2()
        {
            return new Vector2(X, Y);
        }

        public static Vector3 operator *(Vector3 v, float mag)
        {
            return new Vector3(v.X * mag, v.Y * mag, v.Z * mag);
        }


        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3 operator /(Vector3 v, float mag)
        {
            return new Vector3(v.X / mag, v.Y / mag, v.Z / mag);
        }

        public static Vector3 operator /(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
        }

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            if (v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z)
                return true;
            else
                return false;
        }

        public bool Equals(Vector3 pos)
        {
            return pos == this;
        }
    }
}
