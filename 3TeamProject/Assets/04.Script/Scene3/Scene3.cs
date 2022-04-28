using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    public GameObject road;
    public GameObject house;
    public GameObject house2;
    public GameObject hint;
    public GameObject button1;
    public GameObject button2;
    public GameObject end;
    public GameObject system1;
    public GameObject system2;
    public GameObject system3;
    public GameObject system4;


    // Start is called before the first frame update
    void Start()
    {
        road.SetActive(true);
        house.SetActive(false);
        house2.SetActive(false);
        hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 0)
        {

            road.SetActive(true);
        }
        //switch()

        if
        (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 30)
        {
            road.SetActive(false);
            house.SetActive(true);

        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 34)
        {
            house.SetActive(false);
            
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 37)
        {
            system1.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 38)
        {
            system1.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 39)
        {
            house2.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 52)
        {
            house2.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 55)
        {
            system1.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 56)
        {
            system1.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 71)
        {
            system1.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 72)
        {
            system1.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 12 && Input.GetKeyDown(KeyCode.Mouse0))
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
            road.SetActive(true);
            road.SetActive(false);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 24)
        {
            road.SetActive(false);
            road.SetActive(true);

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 29)
        {
            

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 31)
        {
            

        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 32)
        {
            system3.SetActive(true);

        }
    }


    public void Emd()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
        end.SetActive(true);
    }
}
