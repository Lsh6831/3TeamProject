using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc1Button1 : MonoBehaviour
{
    public GameObject button1;
    //¿¹½º
    public void Btt1()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().cnt = 3;
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = true;
        button1.SetActive(false);
    }
    //³ë
    public void Btt2()
    {
        GameObject.Find("ScenesManager").GetComponent<Scene1>().Emd();
        button1.SetActive(false);
    }
}
