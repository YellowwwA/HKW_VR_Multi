using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysensorB : MonoBehaviour
{
    public static string sensorB = "close";

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            sensorB = "open";
        }
    }

}
