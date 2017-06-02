using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour {
    private Rigidbody2D leftHand;
    // Use this for initialization
    void Start () {
        leftHand = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            leftHand.velocity =new Vector2(0f, 6f);
        }
        else if (Input.GetKey(KeyCode.Y))
        {
            leftHand.velocity = new Vector2(0f, -6f);
        }
        else
        {
            leftHand.velocity = new Vector2(0f, 0f);
        }
      
    }
}
