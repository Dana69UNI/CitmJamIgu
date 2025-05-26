using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class CombateMusicHandler : MonoBehaviour
{
    private EventInstance CancionBoss;
    public int boss;
    void Start()
    {
        if (boss==0)
        {
            CancionBoss = AudioManager.instance.CreateInstance(FMODEvents.instance.musicCombate1);
        }
        if(boss==1) 
        {
            CancionBoss = AudioManager.instance.CreateInstance(FMODEvents.instance.musicCombate2);
        }
        if (boss == 2)
        {
            CancionBoss = AudioManager.instance.CreateInstance(FMODEvents.instance.musicCombate3);
        }
        CancionBoss.start();
    }

    private void OnDisable()
    {
        CancionBoss.stop(STOP_MODE.ALLOWFADEOUT);
    }

    private void OnDestroy()
    {
        CancionBoss.stop(STOP_MODE.ALLOWFADEOUT);
    }
}
