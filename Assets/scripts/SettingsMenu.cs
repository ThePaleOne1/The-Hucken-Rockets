using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
	public Slider mainSlider;
	public float newVolume;
	public static float resetVolume;

	public void Start()
	{
		if (TestingBrightness.Started == true)
		{
			mainSlider.value = resetVolume;
		}
	}

	public void Update()
	{
		newVolume = mainSlider.value;
		AudioListener.volume = newVolume;
		resetVolume = mainSlider.value;
	}

}
