using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWindow : MonoBehaviour {
void OnGUI () {
// ラベルを表示する
GUI.Label(new Rect(1,1,1000,1000), "MenuWindow");
}
}