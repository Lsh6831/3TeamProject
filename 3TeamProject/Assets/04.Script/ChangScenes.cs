using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//�� �̵� �Ϸ��� �� �޴����� �ʿ�
public class ChangScenes : MonoBehaviour
{
    public void ChangSceneBtn() 
    {
        //�� �̵� �޼��� ��ư Ŭ���� �ش� ������ �̵�
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
