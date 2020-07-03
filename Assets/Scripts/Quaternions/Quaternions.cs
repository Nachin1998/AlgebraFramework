using System;
using UnityEngine;

namespace CustomMath
{
    public class Quaternions : IEquatable<Quaternions>
    {

        public const float kEpsilon = 1E-06F;
        public float x;
        public float y;
        public float z;
        public float w;

        public Quaternions(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Quaternions(Quaternion q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }

        public static Quaternions identity { get { return new Quaternions(0, 0, 0, 1); } }
        public Vec3 eulerAngles { get; set; }
        public Quaternions normalized { get { Normalize(); return new Quaternions(x, y, z, w); } }

        public static float Angle(Quaternions a, Quaternions b)
        {
            /*
            Returns the angle in degrees between two rotations a and b.

            Example: Think of two GameObjects (A and B) moving around a third GameObject (C). 
            Lines from C to A and C to B create a triangle which can change over time. 
            The angle between CA and CB is the value Quaternion.Angle provides.
            */
            
            /*float result;
            float angleA;
            float angleB;

            result = (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w + b.w);
            angleA = Mathf.Sqrt(a.x + a.y + a.z + a.w);
            angleB = Mathf.Sqrt(b.x + b.y + b.z + b.w);

            return Mathf.Acos(result / (angleA * angleB));*/    

            Quaternions aux = Inverse(a);
            Quaternions result = b * aux;
            float ej = Mathf.Acos(result.w) * 2.0f * Mathf.Rad2Deg;
            return ej;
        }

        public static Quaternions AngleAxis(float angle, Vec3 axis)
        {
            throw new NotImplementedException();
        }

        public static Quaternions AxisAngle(Vec3 axis, float angle)
        {
            throw new NotImplementedException();
        }
        public static float Dot(Quaternions a, Quaternions b)
        {
            float dot;
            dot = (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
            return dot;
        }
        public static Quaternions Euler(Vec3 euler)
        {
            /*
            Returns a rotation that rotates z degrees around the z axis, 
            x degrees around the x axis, and y degrees around the y axis; applied in that order.
            */

            Quaternions aux = new Quaternions(euler.x,euler.y,euler.z,0);
            float rad = Mathf.Deg2Rad;
            euler *= rad;
            aux.x = Mathf.Sin(euler.x * 0.5f);
            aux.y = Mathf.Sin(euler.y * 0.5f);
            aux.z = Mathf.Sin(euler.z * 0.5f);
            aux.w = Mathf.Cos(euler.x * 0.5f) * Mathf.Cos(euler.y * 0.5f) * Mathf.Cos(euler.z * 0.5f) - Mathf.Sin(euler.x * 0.5f) * Mathf.Sin(euler.y * 0.5f) * Mathf.Sin(euler.z * 0.5f);
            aux.Normalize();
            return aux;
        }
        public static Quaternions Euler(float x, float y, float z)
        {
            Quaternions aux = new Quaternions(x,y,z,0);
            float rad = Mathf.Deg2Rad;
            x *= rad;
            y *= rad;
            z *= rad;
            
            aux.x = Mathf.Sin(x * 0.5f);
            aux.y = Mathf.Sin(y * 0.5f);
            aux.z = Mathf.Sin(z * 0.5f);
            aux.w = Mathf.Cos(x * 0.5f) * Mathf.Cos(y * 0.5f) * Mathf.Cos(z * 0.5f) - Mathf.Sin(x * 0.5f) * Mathf.Sin(y * 0.5f) * Mathf.Sin(z * 0.5f);
            aux.Normalize();
            return aux;
        }

        public static Quaternions EulerAngles(float x, float y, float z)
        {
            throw new NotImplementedException();
        }
        
        public static Quaternions EulerAngles(Vec3 euler)
        {
            throw new NotImplementedException();
        }
        
        public static Quaternions EulerRotation(float x, float y, float z)
        {
            throw new NotImplementedException();
        }
        
        public static Quaternions EulerRotation(Vec3 euler)
        {
            throw new NotImplementedException();
        }

        public static Quaternions FromToRotation(Vec3 fromDirection, Vec3 toDirection)
        {
            throw new NotImplementedException();
        }

        public static Quaternions Inverse(Quaternions rotation)
        {
            Quaternions aux = rotation;

            aux.x = -rotation.x;
            aux.y = -rotation.y;
            aux.z = -rotation.z;
            aux.w = rotation.w;

            return aux;
        }

        public static Quaternions Lerp(Quaternions a, Quaternions b, float t)
        {
            Quaternions auxQuat = new Quaternions(0,0,0,0);
            if (t < 1.0f)
            {
                auxQuat.x = a.x + (b.x - a.x) * t;
                auxQuat.y = a.y + (b.y - a.y) * t;
                auxQuat.z = a.z + (b.z - a.z) * t;
                auxQuat.w = a.w + (b.w - a.w) * t;
            }
            auxQuat.Normalize();
            return auxQuat;
        }

        public static Quaternions LerpUnclamped(Quaternion a, Quaternion b, float t)
        {
            throw new NotImplementedException();
        }

        public static Quaternions LookRotation(Vec3 forward)
        {
            throw new NotImplementedException();
        }

        public static Quaternions LookRotation(Vec3 forward, Vec3 upwards)
        {
            throw new NotImplementedException();
        }
        public static Quaternions Normalize(Quaternions q)
        {
            Quaternions normal = q;
            float magnitude = Mathf.Sqrt(q.x * q.x + q.y * q.y + q.z * q.z + q.w * q.w);

            normal.x /= magnitude;
            normal.y /= magnitude;
            normal.z /= magnitude;
            normal.w /= magnitude;

            return normal;
        }
        public static Quaternions RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
        {
            throw new NotImplementedException();
        }

        public static Quaternions Slerp(Quaternion a, Quaternion b, float t)
        {
            throw new NotImplementedException();
        }

        public static Quaternions SlerpUnclamped(Quaternions a, Quaternions b, float t)
        {
            throw new NotImplementedException();
        }

        public static Vec3 ToEulerAngles(Quaternions rotation)
        {
            throw new NotImplementedException();
        }
        public bool Equals(Quaternions other)
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object other)
        {
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public void Normalize()
        {
            float magnitude = Mathf.Sqrt(x * x + y * y + z * z + w * w);

            x /= magnitude;
            y /= magnitude;
            z /= magnitude;
            w /= magnitude;
        }
        public void Set(float newX, float newY, float newZ, float newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }

        public void SetAxisAngle(Vec3 axis, float angle)
        {
            throw new NotImplementedException();
        }
        
        public void SetEulerAngles(Vec3 euler)
        {
            throw new NotImplementedException();
        }
        
        public void SetEulerAngles(float x, float y, float z)
        {
            throw new NotImplementedException();
        }
        
        public void SetEulerRotation(float x, float y, float z)
        {
            throw new NotImplementedException();
        }
        
        public void SetEulerRotation(Vec3 euler)
        {
            throw new NotImplementedException();
        }
        public void SetFromToRotation(Vec3 fromDirection, Vec3 toDirection)
        {
            throw new NotImplementedException();
        }
        public void SetLookRotation(Vec3 view, Vec3 up)
        {
            throw new NotImplementedException();
        }

        public void SetLookRotation(Vec3 view)
        {
            throw new NotImplementedException();
        }
        public void ToAngleAxis(out float angle, out Vec3 axis)
        {
            throw new NotImplementedException();
        }

        public void ToAxisAngle(out Vec3 axis, out float angle)
        {
            throw new NotImplementedException();
        }

        public Vec3 ToEuler()
        {
            throw new NotImplementedException();
        }

        public Vec3 ToEulerAngles()
        {
            throw new NotImplementedException();
        }
        public string ToString(string format)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "X: " + x.ToString() + " Y: " + y.ToString() + " Z: " + z.ToString() + " W: " + w.ToString();
        }
        public static Quaternions operator *(Quaternions lhs, Quaternions rhs)
        {
            return new Quaternions(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        }
        public static bool operator ==(Quaternions lhs, Quaternions rhs)
        {
            if (lhs.x == rhs.x && 
                lhs.y == rhs.y && 
                lhs.z == rhs.z && 
                lhs.w == rhs.w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Quaternions lhs, Quaternions rhs)
        {
            if (lhs.x != rhs.x || 
                lhs.y != rhs.y || 
                lhs.z != rhs.z || 
                lhs.w != rhs.w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
