using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneLight : MonoBehaviour
{

	public Light myLight;

    // Start is called before the first frame update
    void Start()
    {
		myLight.intensity = TestingBrightness.lightValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
