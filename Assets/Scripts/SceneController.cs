using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        BallSpawn(ballPrefab, ballPrefab.GetComponent<Ball>().SpawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colision) {

        if(colision.gameObject.tag=="Gol1"){

           Debug.Log("Gol para jugador 1");

           StartCoroutine("CorutSpawn");
       
       }else if(colision.gameObject.tag=="Gol2"){
       
           Debug.Log("Gol para jugador 2");

           StartCoroutine("CorutSpawn");
       
       }
    }

    private IEnumerator CorutSpawn(){

        Debug.Log("Se ha iniciado la corrutina");

        Destroy(this);

        yield return new WaitForSeconds(3f);

        BallSpawn(ballPrefab, ballPrefab.GetComponent<Ball>().SpawnPoint);
        

    }

    private void BallSpawn(GameObject prefab, Vector2 spawnPoint){
        
        Debug.Log("Se ha hecho spawn a la bola");

        Instantiate(prefab, spawnPoint, Quaternion.identity);

    }
}
