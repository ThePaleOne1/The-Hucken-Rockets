using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject interactsymbol;

    public GameObject Player;
    public float height;
    public float distance;
    public GameObject frontBarrier;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + height, transform.position.z);
        if (transform.position.z > frontBarrier.transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z + distance);
        }


        if (Player.transform.position.z - transform.position.z > Mathf.Abs(distance))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z + distance);
        }


        interactsymbol.transform.position = Player.transform.position;

    }
}