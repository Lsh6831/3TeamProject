using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//씬 이동 하려면 씬 메니저가 필요
public class ChangScenes : MonoBehaviour
{
    public void ChangSceneBtn() 
    {
        //씬 이동 메서드 버튼 클릭시 해당 씬으로 이동
        switch (this.gameObject.name)
        {
            case "Bt0":
                SceneManager.LoadScene("0.Start");
                Debug.Log ("Click0");
                break;
            case "Bt2":
                SceneManager.LoadScene("1.Title");
                Debug.Log("Click2");
                break;
            case "Bt3":
                SceneManager.LoadScene("Scin3");
                Debug.Log("Click3");
                break;


        }
        
    }
   
}
