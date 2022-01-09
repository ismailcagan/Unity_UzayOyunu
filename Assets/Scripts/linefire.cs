using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linefire : MonoBehaviour
{
    public Transform transform;
    public GameObject linefireGO;

    private void Update()
    {
       // fireline();
    }
    public void fireline()
    {
        if(GameController.point >10)
        {
            Instantiate(linefireGO, transform.position,transform.rotation);
            GameController.point -= 10;
        }
    }


}
