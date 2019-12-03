using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public void onClickButton()
    {
        dialogueManager.instance.dequeueConversation();
    }
}
