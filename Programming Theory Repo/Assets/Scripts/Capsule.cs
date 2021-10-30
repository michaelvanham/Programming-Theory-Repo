using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Unit // INHERITANCE
{
    protected override void Dance()
    {
        // rotate in direction of movement
        transform.Rotate(currentVelocity * Time.deltaTime * 50);
    }
}
