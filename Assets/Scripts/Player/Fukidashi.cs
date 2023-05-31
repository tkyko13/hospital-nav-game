using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fukidashi : MonoBehaviour
{
  [SerializeField] TMP_Text text;
  [SerializeField] SpriteRenderer fukidashiImg;

  public void SetText(string message, bool isAnimation)
  {

  }

  void Update()
  {

    if (text.textInfo.characterCount != 0)
    {
      fukidashiImg.size = new Vector2(text.renderedWidth + 0.7f, text.renderedHeight + 0.7f);
    }
    else
    {

    }
  }
}
