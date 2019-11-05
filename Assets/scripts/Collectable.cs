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
	public GameObject Scissors;
	public GameObject ScissorsUI;
	public GameObject Tape;
	public GameObject TapeUI;
	public GameObject EmptyBox;
	public GameObject EmptyBoxUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collectableCount > colectOrder.Length)
        {
            colectOrder[collectableCount].active = true;
        }


        if (collectableCount == colectOrder.Length)
        {
            cat.GetComponent<CatAgent>().isCatChasing = true;
        }
        else
        {
            cat.GetComponent<CatAgent>().isCatChasing = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "collectable") //if you collide with a collectable
        {
            Destroy(col.gameObject); //destroy object
            ++collectableCount; //add 1 to the collectable counter
            collectableCountText.text = "Items Collected: " + collectableCount + "/3";
			if (col.gameObject == Scissors)
			{
				ScissorsUI.SetActive(true);
			}
			if (col.gameObject == Tape)
			{
				TapeUI.SetActive(true);
			}
			if (col.gameObject == EmptyBox)
			{
				EmptyBoxUI.SetActive(true);
			}
		}
    }
}
