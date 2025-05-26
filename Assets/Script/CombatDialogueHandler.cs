using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FMOD.Studio;
using UnityEngine.SceneManagement;
public class CombatDialogueHandler : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public string[] dialogos;
    public float textSpeed;

    private int index;
    private int contEnd;
    public int EndScene;
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
            if (c != ' ')
            {
                PLAYBACK_STATE playbackState;
                playerDialogue.getPlaybackState(out playbackState);
                if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
                {
                    playerDialogue.start();
                }
            }

            yield return new WaitForSeconds(textSpeed);
        }

        if (EndScene == 1)
        {
            SceneManager.LoadScene(sceneBuildIndex: 4);
        }
        if (EndScene == 2)
        {
            SceneManager.LoadScene(sceneBuildIndex: 8);
        }
        if (EndScene == 3)
        {
            SceneManager.LoadScene(sceneBuildIndex: 10);
        }
        if (EndScene == 4)
        {
            StartCoroutine(Esperar3segundos());
        }
    }
    IEnumerator Esperar3segundos()
    {
        yield return new WaitForSeconds(3f);
       
        Application.Quit();
    }
}
