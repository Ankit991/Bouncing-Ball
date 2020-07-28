using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BounceBall : MonoBehaviour
{
    public BounceButton leftbutton, rightbutton;
    public  int JumpSpeed;
    float movement;
    private Rigidbody Ballrb;
    public bool jump;
    public Texture[] texture;
    public AudioSource jumpmusic; 


    private GameManager gamemanager;

  public  int levels=1;
    

    void Start()
    {
        Ballrb = GetComponent<Rigidbody>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (leftbutton.pressed)
        {
            Ballrb.AddForce(Vector3.right * -6);
        }
        if (rightbutton.pressed)
        {
            Ballrb.AddForce(Vector3.right * 6);
        }
        float movement = Input.GetAxis("Horizontal");
        Ballrb.AddForce(Vector3.right * movement * 6);
        if (jump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpmusic.Play();
                Ballrb.AddForce(Vector3.up * JumpSpeed);
                jump = false;
            }
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.CompareTag("Ground"))
        {
            jump = true;
        }
        if (collision.gameObject.tag == "Destination")
        {
            Debug.Log("You won");
            gamemanager.Win();
            levels=2;
        }
      
     
        if (collision.gameObject.tag == "Color")
        {
            this.gameObject.GetComponent<Renderer>().material.mainTexture = texture[Random.Range(0,texture.Length)];
            
        }
        if(collision.gameObject.tag == "Boundry")
        {
            gamemanager.Gameover();
         
           // Destroy(gameObject, 3f);
        }
    }

    public void Jumping()
    {
        if (jump)
        {
            jumpmusic.Play();
            Ballrb.AddForce(Vector3.up * JumpSpeed);
            jump = false;   
        }
    }


   
    public void levelScene2()
    {
        if (levels==2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
