using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque2Behaviour : MonoBehaviour
{
    private GameObject Player;
    private float velocidad = 4f;
    private Rigidbody2D rb;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        Vector3 direccion = (Player.transform.position - transform.position).normalized;
        rb.velocity = direccion * velocidad;
    }
}
