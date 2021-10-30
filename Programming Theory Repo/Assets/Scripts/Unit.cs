using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    protected Vector3 currentVelocity;
    protected float boundsX = 30;
    protected float boundsZ = 30;

    protected virtual void Awake()
    {
        PickNewVelocity();
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move(); // ABSTRACTION
        Dance(); // POYMORPHISM
        CheckBoundary(); // ABSTRACTION
    }

    protected virtual void PickNewVelocity()
    {
        currentVelocity = Random.insideUnitSphere;
        currentVelocity.y = 0;
        currentVelocity *= 10.0f;
    }

    protected virtual void Move()
    {
        // move the unit in previously chosen currentVelocity direction
        transform.position = transform.position + currentVelocity * Time.deltaTime;
    }

    protected virtual void Dance()
    {
        // to be override by children that want to dance
    }

    private void CheckBoundary()
    {
        // destroy if we're outside the boundary
        if (transform.position.x < -boundsX || transform.position.x > boundsX)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position.z < -boundsZ || transform.position.z > boundsZ)
        {
            Destroy(gameObject);
            return;
        }
    }

    public void SetAreaSize(float bX, float bZ) // ENCAPSULATION
    {
        // configure the size of the area the shape should exist in
        boundsX = bX;
        boundsZ = bZ;
    }
}
