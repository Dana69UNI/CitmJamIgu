using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FMOD.Studio;

public class DialogueHandler : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public string[] dialogos;
    public float textSpeed;
    public PlayerController playerController;

    public bool InDialogue;
    private int index;
    private int contEnd;
    private EventInstance playerDialogue;

    void Start()
    {
        playerDialogue = AudioManager.instance.CreateInstance(FMODEvents.instance.playerDialogueVoice);
        textComp.text = string.Empty;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (index < contEnd)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLine();
                playerDialogue.start();
            }
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.SetActive(false);
                InDialogue = false;
                textComp.text = string.Empty;
                contEnd = 0;
                playerController.blockControls();
            }
        }
       

    }
    public void CallDialogue(int Index, int Cont)
    {
        gameObject.SetActive(true);
        index = Index;
        contEnd = Index + Cont;
        InDialogue = true;
        StartCoroutine(TypeLine(Index));
        playerDialogue.start();
        playerController.blockControls();
       
    }

    void NextLine()
    {
        index++;
        textComp.text = string.Empty;
        StartCoroutine(TypeLine(index));
    }

    IEnumerator TypeLine(int index)
    {
        foreach(char c in dialogos[index].ToCharArray())
        {
            textComp.text += c;

            yield return new WaitForSeconds(textSpeed);
        }
        playerDialogue.stop(STOP_MODE.ALLOWFADEOUT);
    }
}
