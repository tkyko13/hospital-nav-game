using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  // Player's speed
  public float speed;

  void Start()
  {

  }

  void Update()
  {
    float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

    transform.Translate(x, y, 0);
  }


  async void OnCollisionEnter(Collision collision)
  {
    Debug.Log("衝突！ in player");
  }
}
