using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

    
public class Buttonds : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public AudioClip hover;
    public AudioClip clicked;
    public AudioSource audio;
    public void OnPointerEnter(PointerEventData ped)
    {
        audio.PlayOneShot(hover);
    }

    public void OnPointerDown(PointerEventData ped)
    {
        audio.PlayOneShot(clicked);
    }

}
