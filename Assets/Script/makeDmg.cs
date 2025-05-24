using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeDmg : MonoBehaviour
{
    private GameObject Player;
    public PlayerHealthDmg dmgs;

    private void Start()
    {
        if(dmgs == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            dmgs = Player.GetComponent<PlayerHealthDmg>();
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            dmgs.TakeDmg();
        }
        
    }
}
