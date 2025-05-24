using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMenu : MonoBehaviour
{
    public int ButtonIndex;
    private int buttonSelected;
    public GameObject canvas;
    public GameObject canvasAccion;
    public GameObject Player;
    public AtaquesCombate atack;
    public Animator Accion;
    public Animator Luchar;
    public Animator Rendir;
    void Start()
    {
        Player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        controlMenu();
        controlAnimator();
    }

    void controlAnimator()
    {
        if(buttonSelected == 0)
        {
            Luchar.SetBool("isSelected", true);
            Accion.SetBool("isSelected", false);
            Rendir.SetBool("isSelected", false);
        }
        if (buttonSelected == 1)
        {
            Luchar.SetBool("isSelected", false);
            Accion.SetBool("isSelected", true);
            Rendir.SetBool("isSelected", false);
        }
        if (buttonSelected == 2)
        {
            Luchar.SetBool("isSelected", false);
            Accion.SetBool("isSelected", false);
            Rendir.SetBool("isSelected", true);
        }
    }

    void controlMenu()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (buttonSelected == 2)
            {
                buttonSelected = 0;
            }
            else
            {
                buttonSelected++;
            }


        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (buttonSelected == 0)
            {
                buttonSelected = 2;
            }
            else
            {
                buttonSelected--;
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (buttonSelected == 2)
            {
                Debug.Log("Rendir");


            }
            if (buttonSelected == 0)
            {
                Debug.Log("luchar");
                canvas.SetActive(false);
                Player.SetActive(true);
                atack.EmpezarSecuencia();
            }
            if (buttonSelected == 1)
            {
                Debug.Log("Actuar");
                canvas.SetActive(false);
                canvasAccion.SetActive(true);

            }

        }
    }
}
