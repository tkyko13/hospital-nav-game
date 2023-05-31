using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField] Camera mainCamera;
  [SerializeField] Transform player;
  void Update()
  {
    mainCamera.transform.position = new Vector3(player.position.x, player.position.y, -1);
  }
}
