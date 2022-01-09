using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public Text pointtxt;
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        pointtxt.text = GameController.point.ToString();
    }
}
