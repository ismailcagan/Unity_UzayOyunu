using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linecontrol : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "alien")
        {
            Destroy(collision.gameObject);
        }
    }
}
