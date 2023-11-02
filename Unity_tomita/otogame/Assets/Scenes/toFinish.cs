using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinish : MonoBehaviour
{
     private void Start()
    {
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {
        transform.position = Vector3.one;

        // 3秒間待つ
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Men 2yu");
    }
}
