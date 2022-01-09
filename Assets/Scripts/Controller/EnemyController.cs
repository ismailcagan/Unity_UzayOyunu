using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float lifetime = 5f;
    float currenttime;
    void Update()
    {
        life();
    }
    public void life()
    {
        currenttime += Time.deltaTime;

        if (currenttime > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
