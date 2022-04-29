using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;
    public GameObject player7;

    
    public GameObject image1;
    public GameObject image2;

    private bool talking = false;



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
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 4)
        {
            player2.SetActive(true);
            
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 5)
        {
            player3.SetActive(true);
            
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 9)
        {
            player4.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 12)
        {
            player5.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 16)
        {
            player6.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 20)
        {
            player7.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 23)
        {
            talking = true;
            Color1();
            image2.SetActive(true);
        }
        if
            (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 30)
        {
            image2.SetActive(false);
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
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 61)
        {
            image2.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 69)
        {
            image2.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 71)
        {
            system1.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 74)
        {
            system1.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 76)
        {
            system1.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 79)
        {
            system1.SetActive(false);
        }       
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 82)
        {
            house2.SetActive(true);
        }
        if
          (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 86)
        {
            image2.SetActive(true);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 95)
        {
            image2.SetActive(false);
        }
        if
           (GameObject.Find("Text").GetComponent<DialogManager>().cnt == 98)
        {
            house2.SetActive(true);
            GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
        }
    }
    public void Color1()
    {
        if (talking == true)
        {
                image1.GetComponent<Image>().color = new Color(0, 0, 0, 0.4f);
                image2.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                Color2();
                }
            
        }  
    }
    public void Color2() 
    { 
    
    }

    public void Emd()
    {
        GameObject.Find("Text").GetComponent<DialogManager>().isDialogue = false;
        end.SetActive(true);
    }
}
