using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMainShip : MonoBehaviour {

    public float speed;
    private Vector3 target = new Vector3(0, 0.0f, 5);
    private int road = -1;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target)
        {
            if (road == -1)
            {
                road = 1;
                target.y = 1.0f;
            }
            else
            {
                road = -1;
                target.y = -1.0f;
            }
        }

    }
}
