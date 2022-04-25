using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public float delay;
    public int cnt;
    public Text textbox;
    public Image imagebox;

    public string[] fulltext;
    public Image[] images;

    private bool isDialogue = false;

    private int count = 0;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;

    }
    private void OnOff(bool _flag)
    {
        textbox.gameObject.SetActive(_flag);
        imagebox.gameObject.SetActive(_flag);

    }
    IEnumerator _typing()
    {
        return null;
    }
    private void NextDialogue()
    {
        textbox.text = fulltext[count];
        //imagebox.sprite = images[count];
    }
    private void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (cnt < fulltext.Length)
                    NextDialogue();
            }
        }
    }
}
