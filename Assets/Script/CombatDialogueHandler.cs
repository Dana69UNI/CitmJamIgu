using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FMOD.Studio;
public class CombatDialogueHandler : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public string[] dialogos;
    public float textSpeed;

    private int index;
    private int contEnd;
    public int EndScene=0;
    private EventInstance playerDialogue;

    void Start()
    {
       playerDialogue = AudioManager.instance.CreateInstance(FMODEvents.instance.playerDialogue);

        
    }

    public void CallDialogue(int Index, int Cont)
    {
        textComp.text = string.Empty;
        gameObject.SetActive(true);
        index = Index;
        contEnd = Index + Cont;
  
        StartCoroutine(TypeLine(Index));
        

    }

    IEnumerator TypeLine(int index)
    {
        foreach (char c in dialogos[index].ToCharArray())
        {

            textComp.text += c;
            if(c != ' ')
            {
                playerDialogue.start();
            }
            
            yield return new WaitForSeconds(textSpeed);
        }
        playerDialogue.stop(STOP_MODE.IMMEDIATE);
        if(EndScene == 1)
        {
            Debug.Log("Acabar primer dia");
        }
        if (EndScene == 2)
        {
            Debug.Log("Acabar Segundo dia");
        }
    }
}
