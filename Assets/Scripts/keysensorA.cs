using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysensorA : MonoBehaviour
{
        public static string sensorA = "close";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Key"))
        {
            //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            sensorA = "open";
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            sensorA = "open";
        }
    }
}