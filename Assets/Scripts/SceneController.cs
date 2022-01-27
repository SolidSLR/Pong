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
        CheckBall();

    }

    private IEnumerator CorutSpawn(){

        Debug.Log("Se ha iniciado la corrutina");

        yield return new WaitForSeconds(3f);

        BallSpawn(ballPrefab, ballPrefab.GetComponent<Ball>().SpawnPoint);
        

    }

    private void BallSpawn(GameObject prefab, Vector2 spawnPoint){
        
        Debug.Log("Se ha hecho spawn a la bola");

        Instantiate(prefab, spawnPoint, Quaternion.identity);

    }

    private void CheckBall(){
        if(GameObject.Find("Ball(Clone)").GetComponent<Ball>().Goal){
            
            Debug.Log("Hay una bola en juego");

        }else {

            StartCoroutine("CorutSpawn");

            Debug.Log("No hay una bola en juego");

        }
    }
}
