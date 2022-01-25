using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed;

    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;

        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        ball.GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
    }
}
