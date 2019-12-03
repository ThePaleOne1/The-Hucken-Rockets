using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinusTeleporter : MonoBehaviour
{
	public GameObject ShrinusObjects;
	public Transform Destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Player")
		{
			other.transform.position = Destination.transform.position;
			ShrinusObjects.SetActive(false);
		}
	}


}
