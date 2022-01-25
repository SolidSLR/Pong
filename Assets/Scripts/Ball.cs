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
        speed = -5f;

        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        ball.GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
    }

    public void OnCollisionEnter2D(Collision2D colision) {

       // Debug.Log("Baia, que golpesito más tonto");

       if(colision.gameObject.tag=="Gol1"){

           Debug.Log("Gol para jugador 1");
       
       }else if(colision.gameObject.tag=="Gol2"){
       
           Debug.Log("Gol para jugador 2");
       
       }else if(colision.gameObject.tag=="Player"){
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
