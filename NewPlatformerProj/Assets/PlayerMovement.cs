using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    float horizontal = 0f;

    public float runSpd = 40f;

    bool jump = false;

	// Update is called once per frame
	void Update () {

        horizontal = Input.GetAxisRaw("Horizontal") * runSpd; // horizontal movement update

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("Jump", true);
        }
	}

    public void OnLanding() {
        animator.SetBool("Jump", false);
    }

    void FixedUpdate()
    {
        // Moves Character
        controller.Move(horizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
