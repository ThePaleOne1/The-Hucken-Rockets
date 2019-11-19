using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingBrightness : MonoBehaviour
{
	//public float GammaCorrection;

	//public Rect SliderLocation;

	public Slider mainSlider;
    float rbgValue = 0.5f;
    void Update()
    {
        rbgValue = mainSlider.value;
    }

	//{
	//	RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);

	//}

	//public void OnGUI()
	//{

	//	GammaCorrection = GUI.HorizontalSlider(SliderLocation, GammaCorrection, 0, 1.0f);

	//}


	/*public float intensity = 1f;

	public Rect SliderLocation;

	public Light[] lights;

	private float[] orglightsintensity = { 0f, 0f, 0f, 0f };

	void Start()
	{

		for (int i = 0; i < lights.Length; i++)
		{

			orglightsintensity[i] = lights[i].intensity;
		}
	}

	void Update()
	{

		for (int i = 0; i < lights.Length; i++)
		{

			lights[i].intensity = orglightsintensity[i] * intensity;
		}

	}

	void OnGUI()
	{

		intensity = GUI.HorizontalSlider(SliderLocation, intensity, 0f, 2f);

	} */

	

	void OnGUI()
	{

		rbgValue = GUI.HorizontalSlider(new Rect (Screen.width/2 - 50, 90, 100, 30), rbgValue, 0f, 1.0f);
		RenderSettings.ambientLight = new Color(rbgValue, rbgValue, rbgValue, 1);

	}


}
