using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabRequest : MonoBehaviour
{
    private RealtimeTransform realtimeTransform;
    private XRGrabInteractable xRGrabInteractable;
    // Start is called before the first frame update
    void Start()
    {
        realtimeTransform = GetComponent<RealtimeTransform>();
        xRGrabInteractable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (xRGrabInteractable.isSelected)
        {
            realtimeTransform.RequestOwnership();
        }
        //if(LDoorOpen.sensor == "open"){
            //Destroy(gameObject,5f);
        //    realtimeTransform.RequestOwnership();
        //}
    }
}
