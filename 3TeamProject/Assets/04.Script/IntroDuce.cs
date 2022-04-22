using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDuce : MonoBehaviour
{
    public GameObject introDuce;
    
    public void IntroDuceBtn()
    {
       
        introDuce.SetActive(true);
        
    }
    public void OutIntroDuceBtn()
    {
        introDuce.SetActive(false);
    }

}
