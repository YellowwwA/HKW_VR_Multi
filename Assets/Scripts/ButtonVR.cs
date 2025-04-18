using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonVR : MonoBehaviour
{
        private RealtimeTransform realtimeTransform;

    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    GameObject HouseDoor;
    private float rot;

    // Start is called before the first frame update
    void Start()
    {           realtimeTransform = GetComponent<RealtimeTransform>();
        isPressed = false;
        rot = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            button.transform.localPosition = new Vector3(0,0.003f,0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
                        realtimeTransform.RequestOwnership();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject == presser){
            button.transform.localPosition = new Vector3(0, 0.02f,0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    
    //public void ROpenDoor()
    //{

        //rot = rot - 1;
        //HouseDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
        
        //sphere.transform.localPosition = new Vector3(0,1,2);

   // }
}
