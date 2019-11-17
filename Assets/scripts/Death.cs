using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{


    public GameObject confetti;
    public GameObject deathScreen;
    public AudioSource aSource;
    public AudioClip ohno;
    public Animator DeathScreenAnim;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);

            //print("kill me bitch");
            Instantiate(confetti, other.gameObject.transform.position, gameObject.transform.rotation);
            aSource.PlayOneShot(ohno);
            Invoke("DeathScreen", 1);
            Invoke("Return", 4);
        }




    }

    void DeathScreen()
    {
        deathScreen.SetActive(true);
        DeathScreenAnim.SetBool("IsPlaying", true);
    }
	void Return()
	{
		SceneManager.LoadScene("MenuScene");
	}
}
