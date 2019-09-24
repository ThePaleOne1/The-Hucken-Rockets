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



    [SerializeField]
    private float detectionRange = 3f;


    
    void Start()
    {
        dogAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
 

        if (Player.GetComponent<SoundGenerator>().soundDetection)//whatever triggure we want
        {
            target = Player.GetComponent<SoundGenerator>().collidedObject;
            dogAgent.destination = target.transform.position; //walk towards position
        }

        if (Vector3.Distance(transform.position, Player.transform.position) < detectionRange)
        {
            dogAgent.destination = Player.transform.position; //walk towards the player specifically
        }

    }
}
