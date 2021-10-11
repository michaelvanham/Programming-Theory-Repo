using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Unit
{
    protected override void Awake()
    {
        base.Awake();
        currentVelocity.y = 1;
    }

    protected override void Dance()
    {
        // bounce from 0y to 2y
        if (transform.position.y < 0.5)
        {
            transform.position = new Vector3(transform.position.x, 0.51f, transform.position.z);
            currentVelocity.y = 3;
        }

        if (transform.position.y > 2)
        {
            transform.position = new Vector3(transform.position.x, 1.9f, transform.position.z);
            currentVelocity.y = -3;
        }
    }

}
