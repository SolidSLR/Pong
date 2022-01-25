using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;

    float actualSpeed;

    GameObject p1;

    GameObject p2;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;

        actualSpeed = speed;

        p1 = GameObject.Find("P1");

        p2 = GameObject.Find("P2");

        if (p1 == null || p2 == null){
            Debug.Log("Algún jugador sin inicializar");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W)){

            //p1.transform.Translate(Vector3.up*speed*Time.deltaTime);
            p1.transform.Translate(Vector3.up * actualSpeed * Time.deltaTime, Space.Self);

        }else if(Input.GetKey(KeyCode.S)){

            //p1.transform.Translate(Vector3.down*speed*Time.deltaTime);
            p1.transform.Translate(Vector3.down * actualSpeed * Time.deltaTime, Space.Self);
        }
        
         if(Input.GetKey(KeyCode.UpArrow)){

            p2.transform.Translate(Vector3.up*speed*Time.deltaTime);

        }else if(Input.GetKey(KeyCode.DownArrow)){

            p2.transform.Translate(Vector3.down*speed*Time.deltaTime);

        } 
    }

    public void OnCollisionEnter(Collision other) {

        Debug.Log("Baia, que golpesito más tonto");
        actualSpeed = 0;
    }
}
