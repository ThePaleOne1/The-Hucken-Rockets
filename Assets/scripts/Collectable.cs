using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public GameObject cat;
    public Text collectableCountText;
    public int collectableCount = 0;
    public GameObject[] colectOrder;
    public GameObject[] headItems;
	public GameObject Scissors;
	public GameObject ScissorsUI;
	public GameObject Tape;
	public GameObject TapeUI;
	public GameObject EmptyBox;
	public GameObject EmptyBoxUI;

    public AudioSource pickupAduioSource;
    public AudioClip pickupClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (collectableCount > colectOrder.Length)
        //{
        //    //colectOrder[collectableCount].active = true;
        //}

        //if (collectableCount == colectOrder.Length)
        //{
            colectOrder[collectableCount].SetActive(true);
        //}

        if (collectableCount == colectOrder.Length - 1)
        {
            cat.GetComponent<CatAgent>().isCatChasing = true;
        }
        else
        {
            cat.GetComponent<CatAgent>().isCatChasing = false;
        }

        //if (collectableCount > 0)
        //{
            headItems[collectableCount - 1].SetActive(true);
        //}







        if (Scissors == null)
        {
            //print("scissors");
            ScissorsUI.SetActive(true);
        }
        if (Tape == null)
        {
            //print("tape");
            TapeUI.SetActive(true);
        }
        if (EmptyBox == null)
        {
           //print("box");
            EmptyBoxUI.SetActive(true);
        }
    }
        

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "collectable") //if you collide with a collectable
        {
            Destroy(col.gameObject); //destroy object
            ++collectableCount; //add 1 to the collectable counter
            collectableCountText.text = "Items Collected: " + collectableCount + "/3";

            print("did it get this far in the code?");
            pickupAduioSource.PlayOneShot(pickupClip);

		}
    }
}
