using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Input
    [System.NonSerialized] public float x, y;
    [System.NonSerialized] public bool jumping, sprinting, crouching;

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
            crouching = true;
        if (Input.GetKeyUp(KeyCode.LeftControl))
            crouching = false;
    }
}
