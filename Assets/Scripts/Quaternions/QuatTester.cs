using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;

public class QuatTester : MonoBehaviour
{
    Quaternions quat1 = new Quaternions(1,1,1,1);
    Quaternion quat2 = new Quaternion(1,1,1,1);
    public enum RespuestaAEjer
    {
        Uno,
        Dos,
        Tres
    }

    public RespuestaAEjer respuestaAEjer = RespuestaAEjer.Uno;

    void Start()
    {
        Debug.Log(quat1);
        quat1 = Quaternions.Inverse(quat1);
        Debug.Log(quat1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (respuestaAEjer)
        {
            case RespuestaAEjer.Uno:

                break;

            case RespuestaAEjer.Dos:

                break;

            case RespuestaAEjer.Tres:

                break;
        }
    }
}