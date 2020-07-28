using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movetonextlevel : MonoBehaviour
{
     int nextsceneload;
   
    // Start is called before the first frame update
    void Start()
    {
        nextsceneload = SceneManager.GetActiveScene().buildIndex + 1;
      
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.DeleteAll();

        }
    }
   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destination"||collision .gameObject.tag=="evel3"||collision.gameObject.tag=="Level4")
        {
           
           // SceneManager.LoadScene(nextsceneload);
            if (nextsceneload > PlayerPrefs.GetInt("levelat"))
            {
                PlayerPrefs.SetInt("levelat", nextsceneload);
                PlayerPrefs.Save();
            }
        }
    }
    
  

}
