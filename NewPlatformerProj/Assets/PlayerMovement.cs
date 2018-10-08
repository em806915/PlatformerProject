using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontal = 0f;

    public float runSpd = 40f;

    bool jump = false;

	// Update is called once per frame
	void Update () {

        horizontal = Input.GetAxisRaw("Horizontal") * runSpd; // horizontal movement update

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
	}

    void FixedUpdate()
    {
        // Moves Character
        controller.Move(horizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
