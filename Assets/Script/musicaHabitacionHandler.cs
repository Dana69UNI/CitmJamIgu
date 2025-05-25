using FMOD.Studio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaHabitacionHandler : MonoBehaviour
{
    private EventInstance Musica12;
    public bool FinalRoom;
    void Start()
    {
        if(!FinalRoom)
        {
            Musica12 = AudioManager.instance.CreateInstance(FMODEvents.instance.music);
        }
        else
        {
            Musica12 = AudioManager.instance.CreateInstance(FMODEvents.instance.musicChunguelas);
        }
        Musica12.start();
    }

    private void OnDisable()
    {
        Musica12.stop(STOP_MODE.ALLOWFADEOUT);
    }

    private void OnDestroy()
    {
        Musica12.stop(STOP_MODE.ALLOWFADEOUT);
    }
}
