using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    public static dialogueManager instance;

    //references to dialogueManager
    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("fix this" + gameObject.name);
        }
        else
            instance = this;
    }

    public GameObject dialogueBox;

    //First in First Out Queue
    private Queue<dialogue.Info> sentences = new Queue<dialogue.Info>();

    public Text nameTxt;
    public Text dialogueTxt;
    public Image dialoguePortrait;
    public float delay = 0.01f;

    private bool currentTyping;
    private string completeText;

    /*void Start()
    {
        sentences = new Queue<string>();
    }*/

    public void initializeConversation(dialogue dg)
    {
        dialogueBox.SetActive(true);

        sentences.Clear();

        foreach(dialogue.Info info in dg.dialogueInfo)
        {
            sentences.Enqueue(info);
        }

        dequeueConversation();

    }

    public void dequeueConversation()
    {
        if(sentences.Count == 0)
        {
            endConversation();
            return;
        }

        dialogue.Info info = sentences.Dequeue();

        nameTxt.text = info.npcName;
        dialogueTxt.text = info.sentences;
        dialoguePortrait.sprite = info.potrait;

        StartCoroutine(TypeText(info));
    }

    IEnumerator TypeText(dialogue.Info info)
    {
        dialogueTxt.text = "";
        foreach(char character in info.sentences.ToCharArray())
        {
            yield return new WaitForSeconds(delay);
            dialogueTxt.text += character;
            yield return null;
        }
    }

    private void endConversation()
    {
        dialogueBox.SetActive(false);
    }

}
