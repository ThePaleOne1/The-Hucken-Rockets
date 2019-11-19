using System.Collections;
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
		lightMain.intensity = mainSlider.value;
		lightMenu.intensity = mainSlider.value;
	}




}
