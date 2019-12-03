using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogAgent : MonoBehaviour
{
    //temportary variable just so i can test if the dog actually finds the target
    public bool foundTarget;
    //target that will constantly change, so the dog will walk towards sounds
    public GameObject target;
    //same as target but this will stay as the player so i can do other calculations
    public GameObject Player;
    //NavMesh Agent reference (fundemental to the AI system)
    NavMeshAgent dogAgent;

    public AudioClip bark;
    AudioSource aSource;



    [SerializeField]
    private float detectionRange = 3f;

    bool hasBarked = false;

    public AudioSource BGaudio;
    public AudioClip calmBG;
    public AudioClip chaseBG;

    void Start()
    {
        dogAgent = GetComponent<NavMeshAgent>();
        aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        //print(Vector3.Distance(transform.position, Player.transform.position));

        //if (Player.GetComponent<SoundGenerator>().soundDetection)//whatever triggure we want
        //{
        //    target = Player.GetComponent<SoundGenerator>().collidedObject;
        //    dogAgent.destination = target.transform.position; //walk towards position
        //}
        
        if (Vector3.Distance(transform.position, Player.transform.position) < detectionRange)
        {
            dogAgent.destination = Player.transform.position; //walk towards the player specifically

            
            if (hasBarked == false)
            {
                
                hasBarked = true;
                aSource.PlayOneShot(bark);
                //Invoke("DoggoBark", Random.Range(3, 10));

            }

            
        }


        if (Vector3.Distance(transform.position, Player.transform.position) > detectionRange)
        {
            hasBarked = false;
            

        }

        if (Vector3.Distance(transform.position, Player.transform.position) == detectionRange)
        {
            if (hasBarked)
            {
                BGaudio.clip = calmBG;
                BGaudio.Play();
            }
            else
            {
                BGaudio.clip = chaseBG;
                BGaudio.Play();
            }
        }

    }


   
}
