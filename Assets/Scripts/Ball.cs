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

    protected bool goal = true;

    public bool Goal{
        get {return goal;}
    }

    private int random; 
    // Start is called before the first frame update
    void Start()
    {

        random = Random.Range(0,2);

        if(random == 0){
            speed = -5f;
        }else if(random == 1){
            speed = 5f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

        CheckBall();

        //Debug.Log(random = Random.Range(0,2));
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

    private void OnTriggerEnter2D(Collider2D colision){
        
       if(colision.gameObject.tag == "Gol1" || colision.gameObject.tag == "Gol2"){

           Debug.Log("Se ha marcado gol");

           Destroy(this.gameObject,1f);

           goal = false;

       }
    }

    private void CheckBall(){
        if(GameObject.Find("Ball(Clone)").GetComponent<Ball>().Goal){
            
            Debug.Log("Hay una bola en juego");
        }else {

            //BallSpawn(ballPrefab, ballPrefab.GetComponent<Ball>().SpawnPoint);

            //StartCoroutine("CorutSpawn");

            goal = true;

            Debug.Log("No hay una bola en juego");

            Debug.Log("Valor de goal en script Ball"+goal);

        }
    }
}
