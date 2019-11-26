using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterClimbing : MonoBehaviour
{

    bool isClimb;
    public KeyCode[] inputkey;
    public float climbSpeed;
    float y;
    public AudioSource UniversalAudioSource;
    public AudioClip ClimbingClip;
    bool isPlayingAudio = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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

