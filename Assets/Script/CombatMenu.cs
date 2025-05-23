using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMenu : MonoBehaviour
{
    public int ButtonIndex;
    private int buttonSelected;
    public GameObject canvas;
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
                buttonSelected = 1;

            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                buttonSelected = 0;

            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (buttonSelected == 1)
                {
                    Debug.Log("Rendir");
                    canvas.SetActive(false);
                    Player.SetActive(true);

                 }
                else
                {
                    Debug.Log("luchar");
                    canvas.SetActive(false);
                    Player.SetActive(true);
                }
            }
        

    }
}
