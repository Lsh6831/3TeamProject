using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    public GameObject pcRoom;
    public GameObject masage;
    public GameObject button1;
    public GameObject button2;
    public GameObject oneRoom;
    public GameObject end;
    public GameObject system1;
    public GameObject system2;
    public GameObject system3;
    public GameObject system4;


    // Start is called before the first frame update
    void Start()
    {
        masage.SetActive(true);
        pcRoom.SetActive(false);
        oneRoom.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 2)
        {
            GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
            button1.SetActive(true);


        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 5)
        {
            masage.SetActive(false);
            pcRoom.SetActive(true);
        }
        //switch()

        if
        (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 15)
        {
            system1.SetActive(true);

        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 16)
        {
            system2.SetActive(true);
            system1.SetActive(false);

        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 17)
        {
            system3.SetActive(true);
            system2.SetActive(false);
            
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 18)
        {
            system4.SetActive(true);
            system3.SetActive(false);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 19)
        {
            
            system4.SetActive(false);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 20)
        {
            pcRoom.SetActive(false);
            oneRoom.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 22)
        {
            button2.SetActive(true);

        }
    }


        public void Emd()
        {
            GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
            end.SetActive(true);
        }
    
}

