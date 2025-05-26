using FMOD.Studio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeDmg : MonoBehaviour
{
    private GameObject Player;
    public PlayerHealthDmg dmgs;
    private EventInstance Hit;
    private void Start()
    {
        Hit = AudioManager.instance.CreateInstance(FMODEvents.instance.playerHit);
        if (dmgs == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            dmgs = Player.GetComponent<PlayerHealthDmg>();
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Hit.start();
            dmgs.TakeDmg();

        }
        
    }
}
