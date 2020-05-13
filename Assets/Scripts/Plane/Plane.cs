using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
using System;

public class Plane : MonoBehaviour
{

    public Plane(Vector3 inNormal, Vector3 inPoint)
    {
        //
        // Resumen:
        //     Creates a plane.
        //
        // Parámetros:
        //   inNormal:
        //
        //   inPoint:
    }

    public Plane(Vector3 inNormal, float d)
    {
        //
        // Resumen:
        //     Creates a plane.
        //
        // Parámetros:
        //   inNormal:
        //
        //   d:
    }

    public Plane(Vector3 a, Vector3 b, Vector3 c)
    {
        a = new Vec3(a.x, a.y, a.z);
        b = new Vec3(b.x, b.y, b.z);
        c = new Vec3(c.x, c.y, c.z);
    }

    //
    // Resumen:
    //     Normal vector of the plane.
    public Vector3 normal { get; set; }
    //
    // Resumen:
    //     Distance from the origin to the plane.
    public float distance { get; set; }
    //
    // Resumen:
    //     Returns a copy of the plane that faces in the opposite direction.
    public Plane flipped { get; }


    public static Plane Translate(Plane plane, Vector3 translation)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Returns a copy of the given plane that is moved in space by the given translation.
        //
        // Parámetros:
        //   plane:
        //     The plane to move in space.
        //
        //   translation:
        //     The offset in space to move the plane with.
        //
        // Devuelve:
        //     The translated plane.
    }

    public Vector3 ClosestPointOnPlane(Vector3 point)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     For a given point returns the closest point on the plane.
        //
        // Parámetros:
        //   point:
        //     The point to project onto the plane.
        //
        // Devuelve:
        //     A point on the plane that is closest to point.
    }

    public void Flip()
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Makes the plane face in the opposite direction.
    }

    public float GetDistanceToPoint(Vector3 point)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Returns a signed distance from plane to point.
        //
        // Parámetros:
        //   point:
    }

    public bool GetSide(Vector3 point)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Is a point on the positive side of the plane?
        //
        // Parámetros:
        //   point:
    }
    public bool Raycast(Ray ray, out float enter)
    {
        throw new NotImplementedException();
    }

    public bool SameSide(Vector3 inPt0, Vector3 inPt1)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Are two points on the same side of the plane?
        //
        // Parámetros:
        //   inPt0:
        //
        //   inPt1:
    }

    public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Sets a plane using three points that lie within it. The points go around clockwise
        //     as you look down on the top surface of the plane.
        //
        // Parámetros:
        //   a:
        //     First point in clockwise order.
        //
        //   b:
        //     Second point in clockwise order.
        //
        //   c:
        //     Third point in clockwise order.
    }

    public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
    {
        throw new NotImplementedException();
        //
        // Resumen:
        //     Sets a plane using a point that lies within it along with a normal to orient
        //     it.
        //
        // Parámetros:
        //   inNormal:
        //     The plane's normal vector.
        //
        //   inPoint:
        //     A point that lies on the plane.
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
    public string ToString(string format)
    {
        throw new NotImplementedException();
    }
    
    public void Translate(Vector3 translation)
    {
        throw new NotImplementedException();
        // Resumen:
        //     Moves the plane in space by the translation vector.
        //
        // Parámetros:
        //   translation:
        //     The offset in space to move the plane with.
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
