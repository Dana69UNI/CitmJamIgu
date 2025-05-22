using System.Collections;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    public GameObject bg;
    public GameObject Roomcenter;
    public GameObject Player;
    public bool isBlocked;
    public DialogueHandler DialogueHandler;

    private float moveDuration = 2f;
    private float playerOffset = 1.7f;

    private bool isMoving = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isBlocked)
        {
            Vector3 movement = transform.position - Roomcenter.transform.position;
            Vector3 bgTarget = bg.transform.position - movement * 2;
            Vector3 playerTarget = Player.transform.position - movement * playerOffset;

            StartCoroutine(MoveRoom(bgTarget, playerTarget));
        }
        else
        {
            //llamar a dialogo!
            Debug.Log("DEBERIA NANANANNA");
            DialogueHandler.CallDialogue(0, 1);
        }
        

    }

    private IEnumerator MoveRoom(Vector3 bgTarget, Vector3 playerTarget)
    {
        isMoving = true;

        Vector3 bgStart = bg.transform.position;
        Vector3 playerStart = Player.transform.position;

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
    }
}
