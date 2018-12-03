using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

    public GameObject saw;
    int direction = 1; //int direction where 0 is stay, 1 right, -1 left   
    float max_right;
    float max_left;

    float speed = 5;

    void Start()
    {

        max_right = saw.transform.position.x + 10F;
        max_left = saw.transform.position.x;

    }

    void Update()
    {
        if (transform.position.x >= max_right)
            direction = -1;

        if (transform.position.x <= max_left)
            direction = 1;

        transform.Translate(speed * direction * Time.deltaTime, 0, 0);
    }
}

