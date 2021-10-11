using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public List<Unit> shapes;

    // Start is called before the first frame update
    void Start()
    {
        SpawnShape();
    }

    // Update is called once per frame
    void Update()
    {
        // spawn new shape every 5s
    }

    void SpawnShape()
    {
        int shapeToSpawn = Random.Range(0, shapes.Count);
        var newShape = Instantiate<Unit>(shapes[shapeToSpawn]);
        newShape.SetAreaSize();
    }
}
