using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    private Animator playerAnim;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
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
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", true);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", true);
            playerAnim.SetBool("Abajo", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.SetBool("Arriba", false);
            playerAnim.SetBool("Izquierda", false);
            playerAnim.SetBool("Derecha", false);
            playerAnim.SetBool("Abajo", true);
        }
       
    }
}
