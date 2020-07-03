using UnityEngine;
using MathDebbuger;
using CustomMath;
using System.Collections.Generic;

public class QuatRespuestas : MonoBehaviour
{
    public enum Ejercicios
    {
        Uno, 
        Dos, 
        Tres
    }
    public Ejercicios ejercicios = Ejercicios.Uno;

    const int max = 3;
    public float angle;
    public Vector3 lineaA;
    float newAngle;
    public GameObject vectorObject;
    List<GameObject> extras = new List<GameObject>();
    private void Start()
    {        
        for (int i = 0; i < 3; i++)
        {
            extras.Add(vectorObject);
        }

        lineaA = new Vec3(10,0,0);
        newAngle = 0;
        VectorDebugger.EnableCoordinates();

        Debug.Log(lineaA.ToString());
        VectorDebugger.AddVector(lineaA, Color.green, "Verde");

        VectorDebugger.EnableEditorView();
    }
    private void Update()
    {
        newAngle += angle;
        Vec3 a = new Vec3(lineaA);
        
        Quaternions q1 = new Quaternions(a.x, a.y, a.z, 0);
        Quaternion q2 = new Quaternion(a.x, a.y, a.z, 0);
        switch (ejercicios)
        {
            case Ejercicios.Uno:
                vectorObject.transform.rotation = Quaternion.Euler(90, newAngle, 0);
                break;
            case Ejercicios.Dos:
                break;
            case Ejercicios.Tres:
                break;
        }
        VectorDebugger.UpdatePosition("Verde", a);
    }

}