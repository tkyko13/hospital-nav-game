using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AAA.OpenAI;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCChat : MonoBehaviour
{
  [SerializeField] string API_KEY;
  [SerializeField] string systemMessage;

  [SerializeField] TMP_Text fukidashi;

  private ChatGPTConnection chatGPTConnection;

  async void Start()
  {
    // ChatGPTのインスタンス化　役割を与える
    chatGPTConnection = new ChatGPTConnection(API_KEY, systemMessage);
    fukidashi.gameObject.SetActive(false);
  }

/// <summary>
/// 話しかける
/// </summary>
/// <param name="message"></param>
/// <returns></returns>
  public async Task<string> TalkAsync(string message)
  {
    fukidashi.gameObject.SetActive(true);
    fukidashi.text = "........";
    ChatGPTResponseModel res = await chatGPTConnection.RequestAsync(message);
    string resMess = res.choices[0].message.content;
    fukidashi.text = resMess;
    return resMess;
  }

/// <summary>
/// ぶつかる
/// </summary>
/// <param name="other"></param>
/// <returns></returns>
  // async void OnCollisionEnter2D(Collision2D other)
  // {
  //   Debug.Log("衝突！");
  //   // 衝突した相手にPlayerタグが付いているとき
  //   if (other.gameObject.tag == "Player")
  //   {
  //     // 自分に話しかけたことにする
  //     string res = await TalkAsync("こんにちは");
  //     fukidashi.text = res;
  //   }
  // }
}
