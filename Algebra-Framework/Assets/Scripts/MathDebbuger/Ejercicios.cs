using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;
using System.Threading.Tasks;

public class Ejercicios : MonoBehaviour
{
    public enum Ejercicio{
        Uno,
        Dos,
        Tres,
        Cuatro,
        Cinco,
        Seis,
        Siete,
        Ocho,
        nueve,
        Diez
    };

    public Ejercicio ejercicio = Ejercicio.Uno;
    
    public Vector3 lineaA;
    public Vector3 lineaB;
    Vec3 ejerResult;

    void Start()
    {
        VectorDebugger.EnableCoordinates();

        Vec3 a = new Vec3(lineaA);
        Vec3 b = new Vec3(lineaB);

        Debug.Log(lineaA.ToString());
        VectorDebugger.AddVector(lineaA, Color.red, "Roja");
        Debug.Log(lineaB.ToString());
        VectorDebugger.AddVector(lineaB, Color.blue, "Azul");
        Debug.Log(ejerResult.ToString());
        VectorDebugger.AddVector(ejerResult, Color.white, "Blanca");

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

        switch (ejercicio)
        {
            case Ejercicio.Uno:
                ejerResult = new Vec3(lineaA + lineaB);
                break;
            case Ejercicio.Dos:
                ejerResult = new Vec3(lineaB - lineaA);
                break;
            case Ejercicio.Tres:
                //VectorDebugger.UpdatePosition("Roja", Vec3.Lerp(linea));
                //ejerResult = new Vec3(Vec3.Dot(lineaA, lineaB));
                break;
            case Ejercicio.Cuatro:
                //VectorDebugger.UpdatePosition("Roja", new Vec3(Vec3.Cross(lineaA, lineaB)));
                // ejerResult = new Vec3(Vec3.Cross(lineaA, lineaB, 1f));
                break;
            case Ejercicio.Cinco:
                //VectorDebugger.UpdatePosition("Roja", new Vec3(Vec3.Lerp(lineaA, lineaB, 1f)));
                // ejerResult = new Vec3(Vec3.Lerp(lineaA, lineaB, 1f));
                break;
            case Ejercicio.Seis:
                break;
            case Ejercicio.Siete:
                break;
            case Ejercicio.Ocho:
                break;
            case Ejercicio.nueve:
                break;
            case Ejercicio.Diez:
                break;
            default:
                Debug.Log("Algebra machine broke");
                break;
        }

        VectorDebugger.UpdatePosition("Roja", lineaA);
        VectorDebugger.UpdatePosition("Azul", lineaB);
        VectorDebugger.UpdatePosition("Blanca", ejerResult);
    }
}
