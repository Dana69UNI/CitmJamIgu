using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithScene : MonoBehaviour
{
    public DialogueHandler dialogueHandler;
    public int DialogoIndex;
    public int ContIndex;
    public bool AlternateDialogue;
    private bool BeenRead=false;
    public int DialogoAltIndex;
    public int ContAltIndex;
    private bool playerInRange = false;

   
    void OnTriggerEnter2D(Collider2D collision)
    {
        playerInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && dialogueHandler.InDialogue==false )
        {
            if(AlternateDialogue && BeenRead)
            {
                dialogueHandler.CallDialogue(DialogoAltIndex, ContAltIndex);
            }
            else
            {
                dialogueHandler.CallDialogue(DialogoIndex, ContIndex);
                BeenRead = true;
            }
            
        }
    }
}
