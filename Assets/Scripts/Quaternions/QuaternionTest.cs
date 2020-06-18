using CustomMath;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTest : MonoBehaviour
{
    public float angulo;
    public float anguloRot;
    Vector3 vector;
    Vector3 vectorRot;

    void Start()
    {
        vector = new Vector3(Mathf.Cos(Mathf.Deg2Rad * 10), Mathf.Sin(Mathf.Deg2Rad * 10));
        vectorRot = new Vector3(Mathf.Cos(Mathf.Deg2Rad * anguloRot * 10), Mathf.Sin(Mathf.Deg2Rad * anguloRot * 10));

        transform.position = new Vector3(transform.position.x * vector.x - transform.rotation.y * vector.y,
                                         transform.position.x * vector.y + transform.position.y * vector.x, 
                                         0.0f);
    }
    void Update()
    {
        vector = new Vector3(Mathf.Cos(Mathf.Deg2Rad * 10), Mathf.Sin(Mathf.Deg2Rad * 10));
        vectorRot = new Vector3(Mathf.Cos(Mathf.Deg2Rad * anguloRot * 10), Mathf.Sin(Mathf.Deg2Rad * anguloRot * 10));

        transform.position = new Vector3(transform.position.x * vector.x - transform.rotation.y * vector.y, 
                                         transform.position.x * vector.y + transform.position.y * vector.x, 
                                         0.0f);

        transform.rotation = new Quaternion(0, 0, vectorRot.x, vectorRot.y);    
    }
}
