using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Enum.direction enamm;
    public Rigidbody2D _rigidbody2D;
    
    float speed = 5f;
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
       
    }
    // Update is called once per frame
    void Update()
    {
        leftmove();
    }
    public void leftmove()
    {
        _rigidbody2D.velocity = directionControl() * speed;
    }
    public Vector2 directionControl()
    {
        Vector2 SelectedDirection;
        if (enamm == Enum.direction.right)
        {
            SelectedDirection = Vector2.right;
        }
        else
        {
            SelectedDirection = Vector2.left;
        }
        return SelectedDirection;
    }
}
