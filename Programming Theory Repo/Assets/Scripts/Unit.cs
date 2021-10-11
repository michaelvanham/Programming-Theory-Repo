using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    protected Vector3 currentVelocity;

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
        Move();
        Dance();
        CheckBoundary();
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
        if (transform.position.x < -30 || transform.position.x > 30)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position.z < -30 || transform.position.z > 30)
        {
            Destroy(gameObject);
            return;
        }
    }

    public void SetAreaSize()
    {
        // configure the size of the area the shape should exist in
    }
}
