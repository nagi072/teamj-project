using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinish : MonoBehaviour
{
     private void Start()
    {
        // �R���[�`���̋N��
        StartCoroutine(DelayCoroutine());
    }

    // �R���[�`���{��
    private IEnumerator DelayCoroutine()
    {
        transform.position = Vector3.one;

        // 3�b�ԑ҂�
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Men 2yu");
    }
}
