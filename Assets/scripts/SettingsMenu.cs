using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public float gammaCorrection;

    public Rect SliderLocation;

    public void Update()
    {
        RenderSettings.ambientLight = new Color(gammaCorrection, gammaCorrection, gammaCorrection, 1.0f);
    }

    public void OnGUI()
    {
        gammaCorrection = GUI.HorizontalSlider(SliderLocation, gammaCorrection, 0, 1.0f);
    }

    public void AdjustVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
