using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    Rigidbody rb;
    public int speed;
    MenuManager menumanager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        menumanager = GameObject.Find("MenuManager").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.CompareTag("Touch"))
        {
            rb.AddForce(Vector3.up * speed);
        }
        if (collision.gameObject.tag == "olor")
        {
            menumanager.Changecolor();
        }
    }
}
