using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc2Button1 : MonoBehaviour
{
    public GameObject button1;
    
    //��ư1
    public void Btt1()
    {
        
        GameObject.Find("Text").GetComponent<DialogManager>().cnt = 15;
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = true;
        button1.SetActive(false);
    }
    //��ư2
    public void Btt2()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().cnt = 13;
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = true;
        button1.SetActive(false);
    }//��ư3
    public void Btt3()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().cnt = 11;
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = true;
        button1.SetActive(false);
    }
}
