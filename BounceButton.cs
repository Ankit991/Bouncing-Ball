using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BounceButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool pressed
    {
        get;
        set;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

   
   
}
