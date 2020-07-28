using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    BounceBall Bounceball;
  
    public Texture [] texture1;
    public GameObject[] balls;
  
    public void level1()
    {
       
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }
    public void level6()
    {
        SceneManager.LoadScene(6);
    }
    public void level7()
    {
        SceneManager.LoadScene(7);
    }
    public void level8()
    {
        SceneManager.LoadScene(8);
    }
    public void level9()
    {
        SceneManager.LoadScene(9);
    }
    public void level10()
    {
        SceneManager.LoadScene(10);
    }
     public void level11()
    {
        SceneManager.LoadScene(11);
    }
    public void level12()
    {
        SceneManager.LoadScene(12);
    }
    public void level13()
    {
        SceneManager.LoadScene(13);
    }
    public void level14()
    {
        SceneManager.LoadScene(14);
    }
    public void level15()
    {
        SceneManager.LoadScene(15);
    }
    public void level16()
    {
        SceneManager.LoadScene(16);
    }
    public void level117()
    {
        SceneManager.LoadScene(17);
    }
    public void level18()
    {
        SceneManager.LoadScene(18);
    }
    public void level19()
    {
        SceneManager.LoadScene(19);
    }
    public void level20()
    {
        SceneManager.LoadScene(20);
    }
    public void level21()
    {
        SceneManager.LoadScene(21);
    }
    public void level22()
    {
        SceneManager.LoadScene(22);
    }
    public void level23()
    {
        SceneManager.LoadScene(23);
    }
    public void level24()
    {
        SceneManager.LoadScene(24);
    }
    public void level25()
    {
        SceneManager.LoadScene(25);
    }
    public void level26()
    {
        SceneManager.LoadScene(26);
    }

    public void Loadlevel() 
    {
        SceneManager.LoadScene("Level1");
    }
    public void Changecolor()
    {
        this.balls[Random.Range(0,balls.Length)].GetComponent<Renderer>().material.mainTexture = texture1 [Random.Range(0, texture1.Length)];

    }
    public void Quit()
    {
        Application.Quit();
    }

}
