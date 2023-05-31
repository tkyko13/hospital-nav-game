﻿using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float speed;

  private Animator animator;

  private void Start()
  {
    animator = GetComponent<Animator>();
  }

  private void Update()
  {
    Vector2 dir = Vector2.zero;
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      dir.x = -1;
      animator.SetInteger("Direction", 3);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      dir.x = 1;
      animator.SetInteger("Direction", 2);
    }

    if (Input.GetKey(KeyCode.UpArrow))
    {
      dir.y = 1;
      animator.SetInteger("Direction", 1);
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
      dir.y = -1;
      animator.SetInteger("Direction", 0);
    }

    dir.Normalize();
    animator.SetBool("IsMoving", dir.magnitude > 0);

    GetComponent<Rigidbody2D>().velocity = speed * dir;
  }
}
