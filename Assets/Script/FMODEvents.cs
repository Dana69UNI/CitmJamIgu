using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODEvents : MonoBehaviour
{

    [field: Header("Music")]
    [field: SerializeField] public EventReference music { get; private set; }
    [field: SerializeField] public EventReference musicChunguelas { get; private set; }
    [field: SerializeField] public EventReference musicCombate1 { get; private set; }
    [field: SerializeField] public EventReference musicCombate2 { get; private set; }
    [field: SerializeField] public EventReference musicCombate3 { get; private set; }

    [field: Header("Player SFX")]
    [field: SerializeField] public EventReference playerFootsteps { get; private set; }

    [field: SerializeField] public EventReference playerDialogue { get; private set; }
    [field: SerializeField] public EventReference playerDialogueVoice { get; private set; }
    [field: SerializeField] public EventReference playerHit { get; private set; }


    public static FMODEvents instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one FMOD Events instance in the scene.");
        }
        instance = this;
    }
}