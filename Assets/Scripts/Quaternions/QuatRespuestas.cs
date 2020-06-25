using UnityEngine;
using CustomMath;
using MathDebbuger;
using EjerciciosAlgebra;

public class QuatRespuestas : MonoBehaviour
{
    public enum RespuestaAEjer
    {
        Uno,
        Dos,
        Tres
    }

    public RespuestaAEjer respuestaAEjer = RespuestaAEjer.Uno;

    public GameObject thing;
    public float angle;
    Quaternion q = new Quaternion(1, 1, 1, 1);
    Quaternions q1 = new Quaternions(1, 1, 1, 1);
    Quaternions q2 = new Quaternions(1, 1, 1, 1);
    Quaternions q3 = new Quaternions(1, 1, 1, 1);
    float timer;

    // Update is called once per frame
    private void Start()
    {
        //Debug.Log(qc + " test");
    }
    void Update()
    {
        angle = Quaternions.Angle(q2, q3);
        thing.transform.rotation = new Quaternion(0, 0, angle, 0);
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