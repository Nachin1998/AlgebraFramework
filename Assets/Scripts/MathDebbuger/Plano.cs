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
            throw new NotImplementedException();
        }
        public Plano(Vector3 inNormal, float d)
        {
            throw new NotImplementedException();
        }
        public Plano(Vector3 a, Vector3 b, Vector3 c)
        {
            throw new NotImplementedException();
        }

        public Vector3 normal { get; set; }
        public float distance { get; set; }
        public Plane flipped { get; }

        public Plane Translate(Plane plane, Vector3 translation)
        {
            throw new NotImplementedException();
        }
        public Vector3 ClosestPointOnPlane(Vector3 point)
        {
            throw new NotImplementedException();
        }
        public void Flip()
        {
            throw new NotImplementedException();
        }
        public float GetDistanceToPoint(Vector3 point) 
        {
            throw new NotImplementedException();
        }
        public bool GetSide(Vector3 point)
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

