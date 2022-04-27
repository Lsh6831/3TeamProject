using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogues
{
    [TextArea]
    //택스트 여러줄로 쓸수 있게 해줌
    public string dialog;
    public Sprite cg;

    //    //public GameObject gameObject;
    //    //public Image img;
}
public class ImageManager : MonoBehaviour
{
    //public enum TalkTarget { A, B }
    //public TalkTarget target = TalkTarget.A;

    //public Image talkA;
    //public Image talkB;

    [SerializeField] private SpriteRenderer spritrCG;
    
    [SerializeField] private SpriteRenderer spriteTXt;
    [SerializeField] private Text textbox;
    [SerializeField] float textDelay; // 텍스트 딜레이

    private bool isDialogue = false;
    //대화가 진행중인지 검사

    private int count = 0;
    //대화가 얼마나 진행 되었는지
    public GameObject choose;
    public GameObject Ending;

    [SerializeField] private Dialogues[] dialogue;

    public int changCount1 = 7;
    public int changCount2 = 0;

    public int endCount1 = 5;


    public void Count(int newcount)
    {
        count = newcount;
    }
    private void Start()
    {
        //StartCoroutine(_typing());
        NextDialogue();
    }
   
    private void OnOff(bool _flag)
    {
        spriteTXt.gameObject.SetActive(_flag);
        spritrCG.gameObject.SetActive(_flag);
        textbox.gameObject.SetActive(_flag);
        
        isDialogue = _flag;
    }
      public void NextDialogue()
    {
        //switch (target)
        //{
        //    case TalkTarget.A:
        //        talkA.color.a = 
        //        talkB.color.a = 0.5f;
        //        break;
        //    case TalkTarget.B:
        //        talkA.a = 0.5f;
        //        talkB.a = 1f;
        //        break;
        //}
        textbox.text = dialogue[count].dialog;
        spritrCG.sprite = dialogue[count].cg;
        //spritrCG.sprite = dialogue[count].cg;
        //target = target == TalkTarget.A ? TalkTarget.B : TalkTarget.B;
        
    }   
IEnumerator _typing()
    {
        

        for (int i = 0; i <= dialogue.Length; i++)
        {
            textbox.text += dialogue[i];
            yield return new WaitForSeconds(textDelay);
        }
        

        //yield return new WaitForSeconds(0f);
        //for(int i = 0; i <= dialogue.Length; i++)
        //{
        //    //textbox.text = dialogue.Substring(0, i);
        //    yield return new WaitForSeconds(textDelay);

        //}


    }
    private void Update()
    {
        if (count == 4)
        {
            Debug.Log("나옴");
            choose.SetActive(true);
            isDialogue = false;
        }
        if(count == endCount1)
        {
            Debug.Log("End");
            count = 8;
        }
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    OnOff(false);
            }
        }
    }

    public void End()
    {
        Ending.SetActive(true);
    }
    public void BttonCount(int newCount)
    {
        isDialogue = true;
        if (newCount == 5)
        {
            count = newCount + 10;
            
        }
        if (newCount <= changCount1)
        {
            count = newCount;
            
        }

    }
}
   
   
