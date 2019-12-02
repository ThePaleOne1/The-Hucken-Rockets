using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingBrightness : MonoBehaviour
{
	/*
	public Light lightMain;
	public Light lightMenu;
	public float lightValue;
	public Slider mainSlider;
	//static public float intensity;

	void Start()
	{
		lightMain = GetComponent<Light>();
		lightMenu = GetComponent<Light>();
	}

	void Update()
	{
		//lightValue = mainSlider.value;
		//lightMain.intensity = lightValue;
		//lightMenu.intensity = lightValue;

		//lightMain.intensity = newIntensity;
		//lightMenu.intensity = newIntensity;

	}

	public void LightIntensity(float newIntensity)
	{
		newIntensity = lightValue;

	}
	*/

	public Slider mainSlider;
	public static float lightValue;
	public Light myLight;

	public static bool Started = false;

	public void Start()
	{
		if (Started == true)
		{
			mainSlider.value = lightValue;
		}
	}

	public void Update()
	{
		lightValue = mainSlider.value;
		myLight.intensity = lightValue;
	}

	public void StartedYes()
	{
		Started = true;
	}
}
