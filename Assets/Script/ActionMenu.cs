using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMenu : MonoBehaviour
{
    public int ButtonIndex;
    private int buttonSelected;
    public GameObject canvas;
    public GameObject canvasAccion;
    public GameObject Player;
    public Animator Hablar;
    public Animator Desoir;
    public Animator Huir;
    void Start()
    {
        Player.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        menuControl();
        animControl();
    }

    void animControl()
    {
        if(buttonSelected == 0)
        {
            Hablar.SetBool("isSelected", true);
            Desoir.SetBool("isSelected", false);
            Huir.SetBool("isSelected", false);
        }
        if (buttonSelected == 1)
        {
            Hablar.SetBool("isSelected", false);
            Desoir.SetBool("isSelected", true);
            Huir.SetBool("isSelected", false);
        }
        if (buttonSelected == 2)
        {
            Desoir.SetBool("isSelected", false);
            Hablar.SetBool("isSelected", false);
            Huir.SetBool("isSelected", true);
        }
    }

    void menuControl()
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
                Debug.Log("Huir");
                canvasAccion.SetActive(false);
                canvas.SetActive(true);

            }
            if (buttonSelected == 0)
            {
                Debug.Log("Hablarlo");
                canvasAccion.SetActive(false);
                canvas.SetActive(true);

            }
            if (buttonSelected == 1)
            {
                Debug.Log("Ignorar");
                canvasAccion.SetActive(false);
                canvas.SetActive(true);

            }

        }
    }
}
