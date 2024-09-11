using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysensorA : MonoBehaviour
{
        public static string sensorA = "close";

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            sensorA = "open";
        }
    }
}
