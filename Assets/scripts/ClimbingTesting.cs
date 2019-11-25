using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ClimbingTesting : MonoBehaviour
{

	public float climbingSpeed = 0.1f;
	public string climbTag = "Climbable";
	public bool climbing = false;
	public bool OnToggle = false;
	//public float speed;

	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
		//speed = 5 * Time.deltaTime;
		//print(speed);	
	}

	
	void OnCollisionStay(Collision other)
	{
		
		if (other.gameObject.tag == climbTag)
		{
			//print("working");
			if (climbing == true)
			{
				//transform.Translate(new Vector3(0, speed, 0));
				GetComponent<Animator>().SetBool("Is Climbing", true);
			}
			if (Input.GetKeyDown(KeyCode.E))
			{
				climbing = true;
			}
		}
	}

	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == climbTag)
		{
			GetComponent<Animator>().SetBool("Is Climbing", false);
			//other.GetComponent<RigidbodyCharacter>().isClimbing = false;
			//other.attachedRigidbody.useGravity = true;
			climbing = false;
			print("not climbing");
		}
	}

	//[SerializeField]
	//float climbSpeed = 0.1f;

	//void OnTriggerStay(Collider other)
	//{
	//	if (!(other.gameObject.tag == "Player"))
	//		return;

	//	if (Input.GetKeyDown(KeyCode.E))
	//	{
	//		other.GetComponent<RigidbodyCharacter>().isClimbing = !other.GetComponent<RigidbodyCharacter>().isClimbing;
	//	}

	//	if (other.GetComponent<RigidbodyCharacter>().isClimbing)
	//	{
	//		other.attachedRigidbody.useGravity = false;

	//		float y;
	//		if (Input.GetAxis("Vertical") != 0)
	//		{
	//			y = Mathf.Abs(Input.GetAxis("Vertical") * climbSpeed);
	//		}
	//		else if (Input.GetAxis("Horizontal") != 0)
	//		{
	//			y = Mathf.Abs(Input.GetAxis("Horizontal") * climbSpeed);
	//		}
	//		else
	//		{
	//			y = -climbSpeed;
	//		}

	//		other.transform.Translate(new Vector3(0, y, 0));

	//		other.GetComponent<Animator>().SetBool("Is Climbing", true);



	//	}
	//	else
	//	{
	//		other.attachedRigidbody.useGravity = true;
	//	}


	//}

	//void OnTriggerExit(Collider other)
	//{
	//	if (other.gameObject.tag == "Player")
	//	{
	//		other.GetComponent<Animator>().SetBool("Is Climbing", false);
	//		other.GetComponent<RigidbodyCharacter>().isClimbing = false;
	//		other.attachedRigidbody.useGravity = true;
	//	}
	//}
}




