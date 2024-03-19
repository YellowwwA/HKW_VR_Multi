using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LDoorOpenB : MonoBehaviour
{
    //GameObject HouseDoor;
    private float rot;
    Vector3 target = new Vector3(-0.749f, -2.84f, 3.27f);
            private RealtimeTransform realtimeTransform;

    // Start is called before the first frame update
    void Start()
    {
         //HouseDoor = GameObject.FindGameObjectWithTag("HouseDoor");
        //rot = 0;
                        realtimeTransform = GetComponent<RealtimeTransform>();
    }

    // Update is called once per frame
    void Update()
    {
               //if (rot > -130)
                //{
                    //rot = rot - 1;
                    //HouseDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
                //}         

        if((keysensorA.sensorA == "open") & (keysensorB.sensorB == "open"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
            //sensor = "open";
            if (rot > -95)
                {
                    rot = rot - 1;
                    transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
                }     
                              realtimeTransform.RequestOwnership();
        }
    }
}
