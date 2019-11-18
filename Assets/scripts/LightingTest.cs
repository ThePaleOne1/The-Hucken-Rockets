using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingTest : MonoBehaviour
{
    float rbgValue = 0.5f;

    public void OnGUI()
    {
        rbgValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 50, 90, 100, 30), rbgValue, 0f, 1.0f);
        RenderSettings.ambientLight = new Color(rbgValue, rbgValue, rbgValue, 1);
        Debug.Log(rbgValue);
    }
}
