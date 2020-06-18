using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;
using CustomMath;
using UnityEngine.UIElements;
using System.Threading;

public class QuatRespuestas : MonoBehaviour
{
    public enum RespuestaAEjer
    {
        Uno,
        Dos,
        Tres
    }

    public RespuestaAEjer respuestaAEjer = RespuestaAEjer.Uno;

    public float angle;
    public Quaternion q1 = new Quaternion(1, 1, 1, 1);
    public Quaternions qc = new Quaternions(1, 1, 1, 1);
    float t;

    // Update is called once per frame
    private void Start()
    {
        Debug.Log(qc + " test");
    }
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