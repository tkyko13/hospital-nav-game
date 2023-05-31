using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputPassWord : MonoBehaviour
{
  const string PASSWORD = "開けゴマ";

  [SerializeField] TMP_InputField inputField;
  [SerializeField] Button button;

  public void Open()
  {
  }
  public void Close() { }

  private void Start()
  {
    button.onClick.AddListener(() =>
    {
      if (inputField.text == PASSWORD)
      {

      }
    });
  }
}
