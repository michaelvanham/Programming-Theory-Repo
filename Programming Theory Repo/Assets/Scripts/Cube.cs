using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Unit // INHERITANCE
{
    protected override void Dance()
    {
        // rotate along y axis only; spin effect
        transform.Rotate(new Vector3(0, 5, 0));
    }
}
