using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireControl : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "alien")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameController.point++;
        }
    }
}
