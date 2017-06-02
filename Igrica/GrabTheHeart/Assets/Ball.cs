using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ball;
    // Use this for initialization
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        StartCoroutine(Pause());
      
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 8.7f)
        {
           
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
                       
        }

        if (this.transform.position.x <= -8.7f)
        {
           
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
               
        }

    }

    IEnumerator Pause()
    {
        int x = Random.Range(-1, 2);
        int y = Random.Range(-1, 2);
        if (x == 0) { x = 1; }
        ball.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        ball.velocity = new Vector2(7f*x, 7f*y);
    }
}
