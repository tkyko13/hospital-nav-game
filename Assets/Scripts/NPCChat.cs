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

  [SerializeField] Text fukidashi;

  private ChatGPTConnection chatGPTConnection;

  async void Start()
  {
    chatGPTConnection = new ChatGPTConnection(API_KEY);
    //    chatGPTConnection.RequestAsync("こんにちは");

    // 上記の処理が終了するタイミングを待つ処理
    // 例えば帰ってきたメッセージをTextに表示させたい場合は、単純に代入だけではできない

    // ChatGPTResponseModel res = await chatGPTConnection.RequestAsync("Hello!");
    // // ここに処理が来るときにはすでにメッセージを受け取っている状態になっている
    // Debug.Log(res.choices[0].message.content);
    // fukidashi.text = res.choices[0].message.content;
  }

  public async Task<string> TalkAsync(string message)
  {
    ChatGPTResponseModel res = await chatGPTConnection.RequestAsync(message);
    return res.choices[0].message.content;
  }

  async void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("衝突！");
    // 衝突した相手にPlayerタグが付いているとき
    if (other.gameObject.tag == "Player")
    {
      fukidashi.text = await TalkAsync("Hello!");
    }
  }


}
