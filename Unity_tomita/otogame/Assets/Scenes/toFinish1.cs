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
            // �R���[�`���̋N��
            StartCoroutine("owari");
        }
    }

    // �R���[�`���{��
    private IEnumerator owari()
    {
        // 3�b�ԑ҂�
        yield return new WaitForSeconds(250f);

        SceneManager.LoadScene("rizaruto");
    }
}
