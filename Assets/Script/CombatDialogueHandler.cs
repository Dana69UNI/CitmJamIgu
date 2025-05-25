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
    }
}
