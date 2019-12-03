using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogues")]
//[System.Serializable]
public class dialogue : ScriptableObject
{
    [System.Serializable]
    public class Info
    {
        public string npcName;
        public Sprite potrait;
        [TextArea(3, 10)]
        public string sentences;
    }

    [Header("Insert Dialogue Information Here:")]
    public Info[] dialogueInfo; 

}
