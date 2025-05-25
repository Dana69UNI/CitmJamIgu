using FMOD.Studio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class PlayerAnimationScript : MonoBehaviour
{
    private Animator playerAnim;
    private EventInstance playerSteps;
    private bool isSounding;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerSteps = AudioManager.instance.CreateInstance(FMODEvents.instance.playerFootsteps);
    }

    void Update()
    {
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetBool("Arriba", true);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", false);
            PLAYBACK_STATE playbackState;
            playerSteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                playerSteps.start();
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", true);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", false);
            PLAYBACK_STATE playbackState;
            playerSteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                playerSteps.start();
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", true);
            playerAnim.SetBool("Abajo", false);
            PLAYBACK_STATE playbackState;
            playerSteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                playerSteps.start();
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", true);
            PLAYBACK_STATE playbackState;
            playerSteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                playerSteps.start();
            }
        }
       
    }
}
