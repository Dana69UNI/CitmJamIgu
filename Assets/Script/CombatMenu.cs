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
    void Start()
    {
        Player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
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
                    canvas.SetActive(false);
                    Player.SetActive(true);

                }
                if (buttonSelected == 0)
                     {
                        Debug.Log("luchar");
                        
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
