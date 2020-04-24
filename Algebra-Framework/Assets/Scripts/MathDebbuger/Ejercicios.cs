using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;

public class Ejercicios : MonoBehaviour
{
    public enum Ejercicio
    {
        Uno, 
        Dos, 
        Tres, 
        Cuatro, 
        Cinco, 
        Seis, 
        Siete, 
        Ocho, 
        Nueve, 
        Diez
    }

    public Ejercicio ejercicio = Ejercicio.Uno;

    public Vector3 lineaA;
    public Vector3 lineaB;
    Vec3 ejerResult;

    //Ayudas
    Vec3 ejerTresVecAux;            
    float ejerCincoTimer = 0;
    float ejerDiezTimer = 0;

    void Start()
    {
        VectorDebugger.EnableCoordinates();

        Debug.Log(lineaA.ToString());
        VectorDebugger.AddVector(lineaA, Color.green, "Verde");
        Debug.Log(lineaB.ToString());
        VectorDebugger.AddVector(lineaB, Color.blue, "Azul");
        Debug.Log(ejerResult.ToString());
        VectorDebugger.AddVector(ejerResult, Color.red, "Roja");

        VectorDebugger.EnableEditorView();
    }

    // Update is called once per frame
    void Update()
    {
        Vec3 a = new Vec3(lineaA);
        Vec3 b = new Vec3(lineaB);

        switch (ejercicio)
        {
            case Ejercicio.Uno:
                ejerResult = new Vec3(a + b);
                break;

            case Ejercicio.Dos:
                ejerResult = new Vec3(b - a);
                break;

            case Ejercicio.Tres:
                //ejerResult = a.Scale(b); no funciona

                ejerTresVecAux = a;
                ejerTresVecAux.Scale(b);
                
                ejerResult = ejerTresVecAux;
                break;

            case Ejercicio.Cuatro:
                ejerResult = Vec3.Cross(b, a);
                break;

            case Ejercicio.Cinco:
                ejerCincoTimer += Time.deltaTime;

                if (ejerCincoTimer >= 1.0f)
                {
                    ejerCincoTimer = 0;
                }

                ejerResult = Vec3.Lerp(a, b, ejerCincoTimer);
                break;

            case Ejercicio.Seis:
                ejerResult = Vec3.Max(a, b);
                break;

            case Ejercicio.Siete:
                break;

            case Ejercicio.Ocho:

                break;
            case Ejercicio.Nueve:
                break;

            case Ejercicio.Diez:
                //Got to work on unclamped?
                //ejerResult = Vec3.LerpUnclamped(a, b, ejerDiezTimer);
                break;
        }

        VectorDebugger.UpdatePosition("Verde", a);
        VectorDebugger.UpdatePosition("Azul", b);
        VectorDebugger.UpdatePosition("Roja", ejerResult);
    }
}