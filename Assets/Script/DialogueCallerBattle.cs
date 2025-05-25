using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCallerBattle : MonoBehaviour
{
    public CombatDialogueHandler dialogueHandler;
    public int DialogoIndex;

    //void OnEnable()
    //{
    //    BattleMessage();
    //}

    void Start()
    {
        BattleMessage();
    }
    private void BattleMessage()
    {
      dialogueHandler.CallDialogue(DialogoIndex, 0);
   
    }
}
