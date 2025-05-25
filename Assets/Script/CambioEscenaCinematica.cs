using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscenaCinematica : MonoBehaviour
{
    public int cinematicaInt;

    void CambiarEscena()
    {
        if (cinematicaInt == 0)
        {
            Debug.Log("Primer combate");

        }
        if (cinematicaInt == 1)
        {
            Debug.Log("Segundo combate");

        }
        if (cinematicaInt == 2)
        {
            Debug.Log("Tercero combate");

        }
    }
}
