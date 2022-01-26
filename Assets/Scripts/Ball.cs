using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed;

    //private GameObject ball;

    private Vector2 spawnPoint = new Vector2(0,0);

    public Vector2 SpawnPoint{
        get { return spawnPoint;}
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = -5f;

        //ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
    }

    public void OnCollisionEnter2D(Collision2D colision) {
 
       if(colision.gameObject.tag=="Player"){

           if(speed>0){

               speed=-speed;

               Debug.Log("Velocidad: "+speed);

           }else if(speed<0){

               speed=-speed;

               Debug.Log("Velocidad: "+speed);

           }
       }
    }
}
