using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speedMove;
    private float gravityForce;
    private Vector3 moveVector;
    private CharacterController ch_controller;

    public Joystick joystick;

    void Start()
    {
      ch_controller = GetComponent<CharacterController>();
    }

    void Update()
    {
      CharacterMove();
      GamingGravity();
    }

    private void CharacterMove()
    {
      moveVector = Vector3.zero;
      moveVector.x = joystick.Horizontal * speedMove;

      moveVector.y = gravityForce;
      ch_controller.Move(moveVector * Time.deltaTime);
    }


    private void GamingGravity()
    {
      if (!ch_controller.isGrounded)
        gravityForce -= 200f * Time.deltaTime;
      else
        gravityForce = -1f;
    }


}
