using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Collectable col;
    public GameObject winObject;
    // Start is called before the first frame update
    void Start()
    {
        winObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (col.collectableCount == col.colectOrder.Length-1  && other.tag == "Player")
        {
            winObject.SetActive(true);
        }
    }
}
