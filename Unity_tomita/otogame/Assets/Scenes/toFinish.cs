using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinish : MonoBehaviour
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
        yield return new WaitForSeconds(25f);

        SceneManager.LoadScene("rizaruto");
    }
}
