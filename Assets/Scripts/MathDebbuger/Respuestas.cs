using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;

public class Respuestas : MonoBehaviour
{
    public enum RespuestaAEjer
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

    public RespuestaAEjer respuestaAEjer = RespuestaAEjer.Uno;

    public Vector3 lineaA;
    public Vector3 lineaB;
    Vector3 lineaEjerResult;

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
        Debug.Log(lineaEjerResult.ToString());
        VectorDebugger.AddVector(lineaEjerResult, Color.red, "Roja");

        VectorDebugger.EnableEditorView();
    }

    // Update is called once per frame
    void Update()
    {
        Vec3 a = new Vec3(lineaA);
        Vec3 b = new Vec3(lineaB);
        Vec3 ejerResult = new Vec3(lineaEjerResult);

        switch (respuestaAEjer)
        {
            case RespuestaAEjer.Uno:
                ejerResult = new Vec3(a + b);
                break;

            case RespuestaAEjer.Dos:
                ejerResult = new Vec3(b - a);
                break;

            case RespuestaAEjer.Tres:
                //ejerResult = a.Scale(b); doesnt work

                ejerTresVecAux = a;
                ejerTresVecAux.Scale(b);
                
                ejerResult = ejerTresVecAux;
                //somehow this works
                break;

            case RespuestaAEjer.Cuatro:
                ejerResult = Vec3.Cross(b, a);
                break;

            case RespuestaAEjer.Cinco:
                ejerCincoTimer += Time.deltaTime;

                if (ejerCincoTimer >= 1.0f)
                {
                    ejerCincoTimer = 0;
                }

                ejerResult = Vec3.Lerp(a, b, ejerCincoTimer);
                break;

            case RespuestaAEjer.Seis:
                ejerResult = Vec3.Max(a, b);
                break;

            case RespuestaAEjer.Siete:
                //Got to work on Project
                //ejerResult = Vec3.Project(a, b);
                break;

            case RespuestaAEjer.Ocho:
                //No idea
                break;

            case RespuestaAEjer.Nueve:
                //Got to work on Reflect
                //ejerResult = Vec3.Reflect(a, b);
                break;

            case RespuestaAEjer.Diez:
                ejerDiezTimer += Time.deltaTime;

                if (ejerDiezTimer >= 10.0f)
                {
                    ejerDiezTimer = 0;
                }

                ejerResult = Vec3.LerpUnclamped(a, b, ejerDiezTimer);
                break;
        }

        VectorDebugger.UpdatePosition("Verde", a);
        VectorDebugger.UpdatePosition("Azul", b);
        VectorDebugger.UpdatePosition("Roja", ejerResult);
    }
}