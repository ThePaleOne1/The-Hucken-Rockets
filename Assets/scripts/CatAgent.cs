using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatAgent : MonoBehaviour
{
    public bool isCatChasing = false;
    public GameObject target;
    NavMeshAgent agent;
    public float detectionRange = 20;
    public GameObject Player;
    bool hasmeowed = false;
    public AudioSource aSource;
    public AudioClip meow;

    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCatChasing)
        {
            agent.SetDestination(target.transform.position);
        }
        else
        {
            agent.SetDestination(transform.position);
        }


        if (Vector3.Distance(transform.position, Player.transform.position) < detectionRange)
        {
            


            if (hasmeowed == false)
            {
                
                hasmeowed = true;
                aSource.PlayOneShot(meow);
                //Invoke("DoggoBark", Random.Range(3, 10));

            }


        }


        if (Vector3.Distance(transform.position, Player.transform.position) > detectionRange)
        {

            hasmeowed = false;


        }


    }

}


