using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

    
public class Buttonds : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public AudioClip hover;
    public AudioClip clicked;
    public AudioSource audioSource;
    public void OnPointerEnter(PointerEventData ped)
    {
        audioSource.PlayOneShot(hover);
    }

    public void OnPointerDown(PointerEventData ped)
    {
        audioSource.PlayOneShot(clicked);
    }

    
}
