using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueHandler : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public string[] dialogos;
    public float textSpeed;

    private int index;
    private int contEnd;
   
    void Start()
    {
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
            }
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.SetActive(false);
                textComp.text = string.Empty;
            }
        }
       

    }
    public void CallDialogue(int Index, int Cont)
    {
        gameObject.SetActive(true);
        contEnd = Index + Cont;
        StartCoroutine(TypeLine(Index));
       
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
    }
}
