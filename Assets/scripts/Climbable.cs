using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbable : MonoBehaviour
{
    public AudioSource UniversalAudioSource;
    public AudioClip ClimbingClip;

    [SerializeField] 
    float climbSpeed = 0.1f;

    bool isPlayingAudio = false;

    public GameObject[] teleports;
    GameObject winingObj;
    float DistanceToBeat;
    void Start()
    {
        DistanceToBeat = 0f;
    }


    void Update()
    {

    }

    

    void OnTriggerStay(Collider other)
    {
        if (!(other.gameObject.tag == "Player"))
            return;

        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!isPlayingAudio)
            {
                UniversalAudioSource.PlayOneShot(ClimbingClip);
                UniversalAudioSource.loop = true;
                isPlayingAudio = true;
                Invoke("ToggleClimbSound", 0.5f);

            }


            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            //UniversalAudioSource.PlayOneShot(ClimbingClip);
            //UniversalAudioSource.loop = true;
            other.GetComponent<RigidbodyCharacter>().isClimbing = !other.GetComponent<RigidbodyCharacter>().isClimbing;
            //if (other.GetComponent<RigidbodyCharacter>().isClimbing)
            //{
                
            //    for (int i = 0; i < teleports.Length; ++i)
            //    {
            //        if (DistanceToBeat < Vector3.Distance(other.gameObject.transform.position, teleports[i].transform.position))
            //        {
            //            DistanceToBeat = Vector3.Distance(other.gameObject.transform.position, teleports[i].transform.position);
            //            winingObj = teleports[i].gameObject;
            //        }
                    
            //    }

            //    other.transform.position = winingObj.transform.position;
            //}
        }

        if (other.GetComponent<RigidbodyCharacter>().isClimbing)
        {
            other.gameObject.GetComponent<RigidbodyCharacter>().climbableObj = gameObject;



            other.attachedRigidbody.useGravity = false;

            float y;
            if (Input.GetAxis("Vertical") != 0)
            {
                y = Input.GetAxis("Vertical") * climbSpeed;
            }
            //else if (Input.GetAxis("Horizontal") != 0)
            //{
            //    y = Mathf.Abs(Input.GetAxis("Horizontal") * climbSpeed);
            //}
            else
            {
                y = 0f;
            }

            other.transform.Translate(new Vector3(0, y, 0));

            other.GetComponent<Animator>().SetBool("Is Climbing", true);

            

        }
        else
        {
            other.attachedRigidbody.useGravity = true;
        }

        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Animator>().SetBool("Is Climbing", false);
            other.GetComponent<RigidbodyCharacter>().isClimbing = false;
            other.attachedRigidbody.useGravity = true;
        }
    }

    void ToggleClimbSound()
    {
        isPlayingAudio = false;
    }
}
