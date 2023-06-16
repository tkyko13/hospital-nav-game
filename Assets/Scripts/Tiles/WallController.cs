using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class WallController : MonoBehaviour
{
  [SerializeField] Tilemap tilemap;
  [SerializeField] TileBase tileBase;

  const string PASSWORD = "ひらけゴマ";

  [SerializeField] TMP_InputField inputField;
  [SerializeField] Button button;

  public void OpenWall()
  {
    tilemap.SetTile(new Vector3Int(2, 5, 0), null);
    tilemap.SetTile(new Vector3Int(2, 6, 0), null);
  }

  public void CloseWall()
  {
  }

  private void Start()
  {
    button.onClick.AddListener(() =>
    {
      if (inputField.text == PASSWORD)
      {
        OpenWall();
      }
      inputField.text = "";
    });
  }
}
