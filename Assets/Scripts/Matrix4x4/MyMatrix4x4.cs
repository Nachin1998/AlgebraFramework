using System;
using UnityEngine;

namespace CustomMath {
    public class MyMatrix4x4 : MonoBehaviour
    {
        public float m00;
        public float m01;
        public float m02;
        public float m03;

        public float m10;
        public float m11;
        public float m12;
        public float m13;
        
        public float m20;
        public float m21;
        public float m22;
        public float m23;
        
        public float m30;
        public float m31;
        public float m32;
        public float m33;

        public MyMatrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            m00 = column0.x;
            m10 = column0.x;
            m20 = column0.x;
            m30 = column0.x;
            
            m01 = column1.y;
            m11 = column1.y;
            m21 = column1.y;
            m31 = column1.y;
            
            m02 = column2.z;
            m12 = column2.z;
            m22 = column2.z;
            m32 = column2.z;
            
            m03 = column3.w;
            m13 = column3.w;
            m23 = column3.w;
            m33 = column3.w;
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
