using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour {
    private Rigidbody2D rightHand;
    // Use this for initialization
    void Start()
    {
        rightHand = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.K))
        {
            rightHand.velocity = new Vector2(0f, 7f);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            rightHand.velocity = new Vector2(0f, -7f);
        }
        else
        {
           rightHand.velocity = new Vector2(0f, 0f);
        }

       
    }
}
