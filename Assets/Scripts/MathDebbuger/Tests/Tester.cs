using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;

public class Tester : MonoBehaviour
{
    public Vector3 lineaA;
    public Vector3 lineaB;
    Vec3 ejer1Result;

    void Start()
    {
        VectorDebugger.EnableCoordinates();

        Vec3 a = new Vec3(lineaA);
        Vec3 b = new Vec3(lineaB);

        Debug.Log(lineaA.ToString());
        VectorDebugger.AddVector(lineaA, Color.red, "Roja");
        Debug.Log(lineaB.ToString());
        VectorDebugger.AddVector(lineaB, Color.blue, "Azul");
        Debug.Log(ejer1Result.ToString());
        VectorDebugger.AddVector(ejer1Result, Color.white, "Blanca");

        VectorDebugger.EnableEditorView();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            VectorDebugger.TurnOffVector("elAzul");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            VectorDebugger.TurnOnVector("elAzul");
        }

        ejer1Result = new Vec3(lineaA + lineaB);
        VectorDebugger.UpdatePosition("Roja", lineaA);
        VectorDebugger.UpdatePosition("Azul", lineaB);
        VectorDebugger.UpdatePosition("Blanca", ejer1Result);
    }
}
