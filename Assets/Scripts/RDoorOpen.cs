using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RDoorOpen : MonoBehaviour
{
    GameObject HouseDoor;
    GameObject HouseDoorA;
    GameObject HouseDoorB;
    private float rot;
    public Transform buttonpress;
    public Transform leverstick;

        private RealtimeTransform realtimeTransform;

    // Start is called before the first frame update
    void Start()
    {
        realtimeTransform = GetComponent<RealtimeTransform>();
        HouseDoor = GameObject.FindGameObjectWithTag("HouseDoor");
        //HouseDoorA = GameObject.FindGameObjectWithTag("HouseDoorsmallA");
        //HouseDoorB = GameObject.FindGameObjectWithTag("HouseDoorsmallB");

        //rot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if((buttonpress.localPosition.y<0.01) && ((leverstick.rotation.eulerAngles.x>41) && (leverstick.rotation.eulerAngles.x<42))){
            if(rot>-140){
             rot = rot - 1;
             HouseDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
             //HouseDoorA.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
             //HouseDoorB.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);

                         realtimeTransform.RequestOwnership();
            }
        }
    }
}
