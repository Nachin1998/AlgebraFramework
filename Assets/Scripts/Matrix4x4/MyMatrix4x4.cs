using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
using System.Runtime.CompilerServices;

namespace CustomMath {
    public class MyMatrix4x4 : MonoBehaviour
    {
        public float m00;
        public float m33;
        public float m23;
        public float m13;
        public float m03;
        public float m32;
        public float m22;
        public float m02;
        public float m12;
        public float m21;
        public float m11;
        public float m01;
        public float m30;
        public float m20;
        public float m10;
        public float m31;

        public MyMatrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            throw new NotImplementedException();
        }

        public static MyMatrix4x4 Rotate(Quaternion q)
        {
            throw new NotImplementedException();
        }

        public static MyMatrix4x4 Scale(Vector3 vector)
        {
            throw new NotImplementedException();
        }

        public static MyMatrix4x4 Translate(Vector3 vector)
        {
            throw new NotImplementedException();
        }

        public static MyMatrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
        {
            throw new NotImplementedException();
        }

        public static Vector4 operator *(MyMatrix4x4 lhs, Vector4 vector)
        {
            throw new NotImplementedException();
        }
        public static MyMatrix4x4 operator *(MyMatrix4x4 lhs, MyMatrix4x4 rhs)
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(MyMatrix4x4 lhs, MyMatrix4x4 rhs)
        {
            throw new NotImplementedException();
        }
        public static bool operator !=(MyMatrix4x4 lhs, MyMatrix4x4 rhs)
        {
            throw new NotImplementedException();
        }
    }
}
