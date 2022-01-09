using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject file;
    public Transform transformm;
    public linefire line;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerfile();
        }
        if (Input.GetMouseButtonDown(1))
        {
            line.fireline();
        }
    }
    public void playerfile()
    {
        Instantiate(file, transformm.position, transformm.rotation);
    }
}
