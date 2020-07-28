using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    
    public Button[] levelbutton;
    void Start()
    {
        int levelat= PlayerPrefs.GetInt("levelat",1);
        for (int i = 0; i < levelbutton.Length;i++ )
        {
            if (i+1 > levelat)
            {
                levelbutton[i].interactable = false;
               
            }
        }
    }


}
