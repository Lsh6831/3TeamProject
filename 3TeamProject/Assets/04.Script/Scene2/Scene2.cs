using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    public GameObject seoulStation;
    public GameObject clcokToul;
    public GameObject seoulStation2;
    public GameObject hint;
    public GameObject button1;
    public GameObject button2;
    public GameObject end;
    public GameObject system1;
    public GameObject sukja1;
    public GameObject system3;
    public GameObject system4;


    // Start is called before the first frame update
    void Start()
    {
        seoulStation.SetActive(true);
        clcokToul.SetActive(false);
        seoulStation2.SetActive(false);
        hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 3)
        {
            
            clcokToul.SetActive(true);
        }
        //switch()

        if
        (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 4)
        {
            hint.SetActive(true);

        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 5)
        {

            hint.SetActive(false);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 9)
        {
            hint.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 10)
        {
            hint.SetActive(false);
            button1.SetActive(true);
            GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 12&&Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject.Find("Text").GetComponent<DialogManager>().cnt = 9;

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 14 && Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject.Find("Text").GetComponent<DialogManager>().cnt = 9;

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 19)
        {

            system1.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 20)
        {
            system1.SetActive(false);
            seoulStation2.SetActive(true);
            clcokToul.SetActive(false);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 24)
        {
            seoulStation2.SetActive(false);
            clcokToul.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 29)
        {
            sukja1.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 31)
        {
            sukja1.SetActive(false);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 32)
        {
            system3.SetActive(true);
            GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
        }
    }


    public void Emd()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
        end.SetActive(true);
    }
}
