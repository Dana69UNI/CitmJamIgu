using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RoomChanger : MonoBehaviour
{
    public GameObject bg;
    public GameObject Roomcenter;
    public GameObject Player;
    public bool isBlocked;
    public DialogueHandler DialogueHandler;
    public int dialogueIndex;
    public int contIndex;
    public bool AlternateDialogue;
    private bool BeenRead = false;
    public int DialogoAltIndex;
    public int ContAltIndex;
    private PlayerController playerController;
    private bool cantChange;

    private float moveDuration = 2f;
    private float playerOffset = 1.7f;

    private bool isMoving = false;

    private void Start()
    {
        playerController = Player.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isBlocked)
        {
            if (!cantChange)
            {
                Vector3 movement = transform.position - Roomcenter.transform.position;
                Vector3 bgTarget = bg.transform.position - movement * 2;
                Vector3 playerTarget = Player.transform.position - movement * playerOffset;

                StartCoroutine(MoveRoom(bgTarget, playerTarget));
            }
        }
        else
        {
            
            
            if(DialogueHandler.InDialogue==false)
            {
                if (AlternateDialogue && BeenRead)
                {
                    DialogueHandler.CallDialogue(DialogoAltIndex, ContAltIndex);
                }
                else
                {
                    DialogueHandler.CallDialogue(dialogueIndex, contIndex);
                    BeenRead = true;
                }
                    
            }
            
        }
        

    }

    private IEnumerator MoveRoom(Vector3 bgTarget, Vector3 playerTarget)
    {
        isMoving = true;
        playerController.blockControls();
        Vector3 bgStart = bg.transform.position;
        Vector3 playerStart = Player.transform.position;
        cantChange = true;
        float elapsed = 0f;
        while (elapsed < moveDuration)
        {
            float t = elapsed / moveDuration;
            bg.transform.position = Vector3.Lerp(bgStart, bgTarget, t);
            Player.transform.position = Vector3.Lerp(playerStart, playerTarget, t);

            elapsed += Time.deltaTime;
            yield return null;
        }

        bg.transform.position = bgTarget;
        Player.transform.position = playerTarget;

        isMoving = false;
        playerController.blockControls();
        StartCoroutine(coolDownMoverse());
    }

    private IEnumerator coolDownMoverse()
    {
        
        float elapsed = 0f;
        while (elapsed < 1f)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }
        cantChange = false;
    }
}
