using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  /// <summary>
  /// ぶつかる
  /// </summary>
  /// <param name="other"></param>
  /// <returns></returns>
  void OnCollisionEnter2D(Collision2D other)
  {
    // Debug.Log("衝突！ in player " + other.gameObject.tag);
    // 衝突した相手にPlayerタグが付いているとき
    if (other.gameObject.tag == "NPC")
    {
      // NPCに話しかける
      NPCStatus status = other.gameObject.GetComponent<NPCStatus>();
      NPCChat chat = other.gameObject.GetComponent<NPCChat>();

      TalkToNPC("こんにちは！", status, chat);
    }
  }

  private async void TalkToNPC(string message, NPCStatus status, NPCChat chat)
  {
    string res = await chat.TalkAsync(message);
    Debug.Log("プレイヤー「" + message + "」\n" + status.name + "「" + res + "」");
  }
}
