using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cho1 : MonoBehaviour
{
    public int buttonCount1;
    public int buttonCount2;
    public int buttonCount3;
    public GameObject button;


    public void Button1()
    {
       GameObject.Find("Canvas").GetComponent<TalkManager>().BttonCount(5);
        GameObject.Find("Canvas").GetComponent<TalkManager>().NextDialogue();
        button.SetActive(false);
      
    }
    public void Button2()
    {
        GameObject.Find("Canvas").GetComponent<TalkManager>().BttonCount(buttonCount2);
        GameObject.Find("Canvas").GetComponent<TalkManager>().NextDialogue();
        button.SetActive(false);
    }
    public void Button3()
    {
        GameObject.Find("Canvas").GetComponent<TalkManager>().End();
        
    }


}