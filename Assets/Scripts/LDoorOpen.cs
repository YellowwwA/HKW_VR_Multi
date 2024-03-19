using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LDoorOpen : MonoBehaviour
{
    Vector3 target = new Vector3(-55.99f, 14.7f, -74.35f);
    //public static string sensor;
            private RealtimeTransform realtimeTransform;

    // Start is called before the first frame update
    void Start()
    {
                        realtimeTransform = GetComponent<RealtimeTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if((keysensorA.sensorA == "open") & (keysensorB.sensorB == "open"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.005f);
            //sensor = "open";
                              realtimeTransform.RequestOwnership();
        }
    }
    /*
    private void OnTriggerEnter(Collider collision)
    {
        if((keysensorA.sensorA == "open") & (keysensorB.sensorB == "open"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            //sensor = "open";
                              realtimeTransform.RequestOwnership();
        }
    }*/
}
