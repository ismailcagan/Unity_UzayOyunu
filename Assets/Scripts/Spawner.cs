using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float startRandom = 1f;
    float finishRandom = 2f;
    int sayi;
    float occurrencetime;
    float currentTime;
    public GameObject []enemyies; 
 
    void Update()
    {
        random();
        timeCounter();
        born();
    }
    public void random()
    {
        occurrencetime = Random.Range(startRandom, finishRandom);
        sayi = Random.Range(0, 3);
    }
    public void born()
    {
        if (currentTime > occurrencetime)
        {
            Instantiate(enemyies[sayi], this.transform);
            currentTime = 0;
        }
    }
    public void timeCounter()
    {
        currentTime += Time.deltaTime;
    }

}
