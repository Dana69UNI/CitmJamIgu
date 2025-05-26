using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioEscenaCinematica : MonoBehaviour
{
    public int cinematicaInt;

    void CambiarEscena()
    {
        if (cinematicaInt == 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);

        }
        if (cinematicaInt == 1)
        {
            SceneManager.LoadScene(sceneBuildIndex: 6);

        }
        if (cinematicaInt == 2)
        {
            SceneManager.LoadScene(sceneBuildIndex: 10);

        }
        if (cinematicaInt == 3)
        {
            SceneManager.LoadScene(sceneBuildIndex: 12);

        }
    }
}
