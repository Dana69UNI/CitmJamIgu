using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class AtaquesCombate : MonoBehaviour
{
    private float ataque2Duracion = 20f;
    public GameObject AtaqueGO2;
    public UnityEngine.Transform Spawner1;
    public UnityEngine.Transform Spawner2;
    private int SelectedSpawn;
    Vector3 posicionInicial;
    private bool FirstAttack=true;

    public void EmpezarSecuencia()
    {
        posicionInicial = transform.position;
        StartCoroutine(Ataque1(-20f, 19f));

    }

    IEnumerator Ataque1(float distancia, float duracion)
    {
        gameObject.transform.position = posicionInicial;
        Vector3 posicionFinal = posicionInicial + new Vector3(0, distancia, 0);
        float tiempoTranscurrido = 0f;

        while (tiempoTranscurrido < duracion)
        {
            transform.position = Vector3.Lerp(posicionInicial, posicionFinal, tiempoTranscurrido / duracion);
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }
        if(FirstAttack)
        {
            FirstAttack = false;
            StartCoroutine(CooldownAtaque());
        }
        else
        {
            Debug.Log("Acabó la pelia");
        }
    }

    IEnumerator CooldownAtaque()
    {
        float tiempoTranscurrido = 0f;

        while (tiempoTranscurrido < 0.5f)
        {
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(Ataque2());
    }

    IEnumerator Ataque2()
    {
        float tiempoTranscurrido = 0f;
        float[] tiemposDeAtaque = {0f, 2f, 4f, 5f, 6f, 7f ,9f, 11f, 13f, 16f, 17f, 18f, 19f, 20f };
        int siguienteAtaque = 0;

        while (tiempoTranscurrido < ataque2Duracion)
        {
            if (siguienteAtaque < tiemposDeAtaque.Length && tiempoTranscurrido >= tiemposDeAtaque[siguienteAtaque])
            {
                randomizeSpawn();

                if (SelectedSpawn == 0)
                    Instantiate(AtaqueGO2, Spawner1.position, Quaternion.identity);
                else
                    Instantiate(AtaqueGO2, Spawner2.position, Quaternion.identity);

                siguienteAtaque++;
            }

            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(Ataque1(-20f, 17f));
    }

    void randomizeSpawn()
    {
        SelectedSpawn = UnityEngine.Random.Range(0, 2);
    }
}
