using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  public void OnClickFullScreenMode()
  {
    // フルスクリーンモードに切り替えます
    Screen.fullScreen = true;
  }

  public void OnClickWindowMode()
  {
    // ウィンドウモードに切り替えます
    Screen.fullScreen = false;
  }
}