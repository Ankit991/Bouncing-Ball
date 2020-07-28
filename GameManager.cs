using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;  
    public GameObject Imagewin;
    public GameObject wintext, Gameovertext, Restart;
    public GameObject winparticle;
  
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Gameover()
    {
      
        Gameovertext.SetActive(true);
        Restart.SetActive(true);
        
        ball.SetActive(false);
    }
    public void Win()
    {
        Imagewin.SetActive(true);
        wintext.SetActive(true);
        winparticle.SetActive(true); 
    }
  
 
}
