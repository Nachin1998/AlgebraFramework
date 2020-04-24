using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;

public class ShipShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 shootingVector;
    float movingX;
    float timer;

    void Update()
    {
        //W.I.P.
        Vec3 shot = new Vec3(shootingVector);        

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bulletPrefab);
        }
        
        timer += Time.deltaTime;
        
        movingX += 5 * Time.deltaTime;
        
        shot = new Vec3(movingX, 0, 0);

        bulletPrefab.transform.position = new Vec3(shot);

        if (timer > 5.0f)
        {
            Destroy(gameObject);
        }

        Debug.Log(timer);
    }
}
