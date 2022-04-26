using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShortTalk : MonoBehaviour
{
    public Text tx;
    public string m_text = "안녕하세요 게임 메니저 H입니다";

   
    void Start()
    {
        StartCoroutine(_typing());
    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(1f);
        for(int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(0.15f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
