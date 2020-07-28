using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform bounceball;
    public   Vector3 offset,offset1;
    public Light spotlight;
    private void LateUpdate()
    {
        this.gameObject.transform.position = bounceball.position + offset;
        spotlight.transform.position = bounceball.position+offset1;
    }
}
