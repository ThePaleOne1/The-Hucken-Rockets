﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingBrightness : MonoBehaviour
{

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


}
