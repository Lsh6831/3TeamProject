using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    //택스트 여러줄로 쓸수 있게 해줌
    public string dialogue;
    public Sprite cg;
    public GameObject gameObject;
    //public Image img;
}
public class TalkManager : MonoBehaviour
{
    public enum TalkTarget { A, B }
    public TalkTarget target = TalkTarget.A;

    public Image talkA;
    public Image talkB;

    [SerializeField] private SpriteRenderer spritrCG;
    [SerializeField] private Image image;
    [SerializeField] private SpriteRenderer spriteTXt;
    [SerializeField] private Text textbox;

    private bool isDialogue = false;
    //대화가 진행중인지 검사

    private int count = 0;
    //대화가 얼마나 진행 되었는지

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }
    private void OnOff(bool _flag)
    {
        spriteTXt.gameObject.SetActive(_flag);
        spritrCG.gameObject.SetActive(_flag);
        textbox.gameObject.SetActive(_flag);
        image.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }
      private void NextDialogue()
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
        textbox.text = dialogue[count].dialogue;
        image.sprite = dialogue[count].cg;
        //spritrCG.sprite = dialogue[count].cg;
        //target = target == TalkTarget.A ? TalkTarget.B : TalkTarget.B;
        count++;
    }
    private void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    OnOff(false);
            }
        }
    }
}
   
   
