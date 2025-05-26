using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthDmg : MonoBehaviour
{
    private int Health = 3;
    private bool cdDmg = true;

    public void TakeDmg()
    {
        if (cdDmg)
        {
            Health--;
            Debug.Log("Damages");
            StartCoroutine(CooldownDmgs());
            if (Health <= 0)
            {
                SceneManager.LoadScene(sceneBuildIndex: 11);
            }
        }
    }

    IEnumerator CooldownDmgs()
    {
        cdDmg = false;
        yield return new WaitForSeconds(1f); // Cooldown de 1 segundo
        cdDmg = true;
    }

}
