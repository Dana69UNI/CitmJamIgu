using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatDialogueHandler : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public string[] dialogos;
    public float textSpeed;

    private int index;
    private int contEnd;
    public int EndScene=0;

    void Start()
    {
       

        
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
            yield return new WaitForSeconds(textSpeed);
        }
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
