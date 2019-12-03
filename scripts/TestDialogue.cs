using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    public dialogue dialog;

    public void triggerDialogue()
    {
        dialogueManager.instance.initializeConversation(dialog);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            triggerDialogue();
        }
    }


}
