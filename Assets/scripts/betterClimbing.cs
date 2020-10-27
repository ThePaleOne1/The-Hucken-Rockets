using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This goes on any hit box that you want to make climbable.
/// This should be seperate from the actual mesh of the climbable object.
/// instead use a child object with just the trigger box for teh climable regions
/// </summary>
public class betterClimbing : MonoBehaviour
{

    
    public KeyCode[] inputkey;
    public float climbSpeed;
    
    public AudioSource UniversalAudioSource;
    public AudioClip ClimbingClip;
    bool isPlayingAudio = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && (Input.GetKey(inputkey[0]) || Input.GetKey(inputkey[1])))
        {

                other.GetComponent<RigidbodyCharacter>().isClimbing = true;
                other.transform.Translate(new Vector3(0, climbSpeed, 0));
                other.GetComponent<Animator>().SetBool("Is Climbing", true);

            if (!isPlayingAudio)
            {
                UniversalAudioSource.PlayOneShot(ClimbingClip);
                isPlayingAudio = true;
                Invoke("ToggleClimbSound", 0.5f);
            }

        }
        else
        {
            other.GetComponent<RigidbodyCharacter>().isClimbing = false;
            other.GetComponent<Animator>().SetBool("Is Climbing", false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<RigidbodyCharacter>().isClimbing = false;
            other.GetComponent<Animator>().SetBool("Is Climbing", false);
        }
    }

    void ToggleClimbSound()
    {
        isPlayingAudio = false;
    }
}

