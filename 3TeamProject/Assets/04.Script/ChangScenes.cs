using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScenes : MonoBehaviour
{
    public void ChangSceneBtn() 
    {
        switch (this.gameObject.name)
        {
            case "Bt0":
                SceneManager.LoadScene("Scin0");
                Debug.Log ("Click0");
                break;
            case "Bt1":
                SceneManager.LoadScene("Scin1");
                Debug.Log("Click1");
                break;
            case "Bt2":
                SceneManager.LoadScene("Scin2");
                Debug.Log("Click2");
                break;
            case "Bt3":
                SceneManager.LoadScene("Scin3");
                Debug.Log("Click3");
                break;


        }
    }
}
