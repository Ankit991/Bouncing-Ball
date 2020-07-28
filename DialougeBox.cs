using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialougeBox : MonoBehaviour
{
    public TextMeshProUGUI dialouge;
    public string[] sentence;
    private int index;
    public float typingspeed;
    public GameObject continueButton;
    IEnumerator Type()
    {
        foreach(char letter in sentence[index].ToCharArray ())
        {
            dialouge.text += letter;
            yield return new WaitForSeconds(typingspeed );
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type()); 
    }
    private void Update()
    {
        if (dialouge.text == sentence[index])
        {
            continueButton.SetActive(true);
        }
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentence.Length - 1)
        {
            index++;
            dialouge.text = "";
            StartCoroutine(Type());
        }else
        {
            dialouge.text = "";
            continueButton.SetActive(false);
        }
    }
}
