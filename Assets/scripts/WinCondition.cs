using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (col.collectableCount == 3  && other.tag == "Player")
        {
            SceneManager.LoadScene(3);

        }

    }
}
