using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMusic : MonoBehaviour
{
    AudioSource auSource;
    public AudioClip defaultMusic;
    public AudioClip chaseMusic;
    Collectable col;
    // Start is called before the first frame update
    void Start()
    {
        auSource = GetComponent<AudioSource>();
        auSource.clip = defaultMusic;
        col = GetComponent<Collectable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (col.collectableCount == col.colectOrder.Length)
        {
            auSource.clip = chaseMusic;
        }
        else
        {
            auSource.clip = defaultMusic;
        }
    }
}
