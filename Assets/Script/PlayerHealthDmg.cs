using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthDmg : MonoBehaviour
{
    private int Health = 10;
    private bool cdDmg = true;
    private Animator corAnim;

    private void Start()
    {
        corAnim = GetComponent<Animator>();
    }

    public void TakeDmg()
    {
        if (cdDmg)
        {
            Health--;
            corAnim.SetBool("isHit", true);
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
        corAnim.SetBool("isHit", false);
        cdDmg = true;
    }

}
