using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour {

    public GameObject mace;
    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    float top;
    float bottom;

    float speed = 5;

    void Start() {

        top = mace.transform.position.y + 4F;
        bottom = mace.transform.position.y;

    }

    void Update()
    {
        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(0, speed * direction * Time.deltaTime, 0);
    }
}
