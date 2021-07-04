using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Input
    [System.NonSerialized] public float x, y;
    [System.NonSerialized] public bool jumping, sprinting, crouching;

    // Assignables
    public PlayerMovement playerMovement;

    private void Update()
    {
        MyInput();
    }

    private void MyInput() {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        jumping = Input.GetButton("Jump");
        crouching = Input.GetKey(KeyCode.LeftControl);
      
        //Crouching
        if (Input.GetKeyDown(KeyCode.LeftControl))
            playerMovement.StartCrouch();
        if (Input.GetKeyUp(KeyCode.LeftControl))
            playerMovement.StopCrouch();
    }
}
