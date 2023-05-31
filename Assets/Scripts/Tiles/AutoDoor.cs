using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("衝突！ " + other.gameObject.name);

    this.gameObject.SetActive(false);
  }
}
