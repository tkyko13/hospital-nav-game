using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWork : MonoBehaviour
{
  private bool isWork = false;
  private int nextWork = 60;
  private int workTime = 30;
  private Vector3 workVector = Vector3.zero;

  private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
            // 最初の向き (下) を設定する
    _animator.SetFloat("x", 0);
    _animator.SetFloat("y", 1);
    }


    void Update()
    {
      nextWork--;
      if(nextWork < 0) {
        isWork = true;
        nextWork = Random.Range(60*5, 60*8);

        int r = Random.Range(0, 4);
        if(r == 0)  workVector = new Vector3(-1, 0, 0);
        else if(r == 1) workVector = new Vector3(1, 0, 0);
        else if(r == 2) workVector = new Vector3(0, -1, 0);
        else if(r == 3) workVector = new Vector3(0, 1, 0);
      }

      if(isWork) {
        workTime--;
        if(workTime < 0) {
          isWork = false;
          workTime = 60;//Random.Range(10, 30);
        }
        else {
          // 実際にキャラの座標移動
          this.transform.localPosition += workVector * 0.01f;
          // キャラのアニメーション
          _animator.SetFloat("x", workVector.x);
          _animator.SetFloat("y", workVector.y);
        }
      }      
    }
}
