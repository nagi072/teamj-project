using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  public void OnClickFullScreenMode()
  {
    // �t���X�N���[�����[�h�ɐ؂�ւ��܂�
    Screen.fullScreen = true;
  }

  public void OnClickWindowMode()
  {
    // �E�B���h�E���[�h�ɐ؂�ւ��܂�
    Screen.fullScreen = false;
  }
}