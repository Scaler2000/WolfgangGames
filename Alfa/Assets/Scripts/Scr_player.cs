using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scr_player : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;

    float hspeed = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        hspeed = Input.GetAxisRaw("Horizontal")*runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
        controller.Move(hspeed*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
