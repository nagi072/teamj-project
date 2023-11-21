using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinish1 : MonoBehaviour
{
     private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // コルーチンの起動
            StartCoroutine("owari");
        }
    }

    // コルーチン本体
    private IEnumerator owari()
    {
        // 3秒間待つ
        yield return new WaitForSeconds(250f);

        SceneManager.LoadScene("rizaruto");
    }
}
