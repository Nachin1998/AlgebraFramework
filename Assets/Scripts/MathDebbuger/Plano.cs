using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
using System;

namespace CustomMath
{
    public class Plano : MonoBehaviour
    {
        public Plano(Vector3 inNormal, Vector3 inPoint)
        {
            normal = inNormal.normalized;
            distance = Mathf.Abs(((normal.x * inPoint.x) +
                                  (normal.y * inPoint.y) +
                                  (normal.z * inPoint.z))) / Vector3.Magnitude(normal);
        }

        public Plano(Vector3 a, Vector3 b, Vector3 c)
        {
            throw new NotImplementedException();
        }

        public Vector3 normal { get; set; }
        public float distance { get; set; }
        public Plane flipped { get; }


        public static Plane Translate(Plane plane, Vector3 translation)
        {
            throw new NotImplementedException();
        }

        public Vector3 ClosestPointOnPlane(Vector3 point)
        {
            throw new NotImplementedException();
        }

        public void Flip()
        {
            normal *= -1;
            distance *= -1;
        }

        public float GetDistanceToPoint(Vector3 point)
        {
            float aux;
            aux = Mathf.Abs(((normal.x * point.x) +
                             (normal.y * point.y) +
                             (normal.z * point.z))) / Vector3.Magnitude(normal) + distance;
            return aux;
        }
        public bool GetSide(Vector3 point)
        {
            float aux = GetDistanceToPoint(point);
            if (aux > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Raycast(Ray ray, out float enter)
        {
            throw new NotImplementedException();
        }

        public bool SameSide(Vector3 inPt0, Vector3 inPt1)
        {
            throw new NotImplementedException();
        }

        public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
        {
            throw new NotImplementedException();
        }

        public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        public string ToString(string format)
        {
            throw new NotImplementedException();
        }

        public void Translate(Vector3 translation)
        {
            throw new NotImplementedException();
        }
    }
}

