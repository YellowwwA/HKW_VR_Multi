using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportController : MonoBehaviour
{
    public XRController leftcontroller;
    public XRController rightcontroller;
    public InputHelpers.Button teleportRayButton;
    public float activationThreshold = 0.1f;
    private XRInteractorLineVisual leftRay;
    private GameObject leftReticle;
    private XRInteractorLineVisual rightRay;
    private GameObject rightReticle;


    // Start is called before the first frame update
    void Start()
    {
        leftRay = leftcontroller.gameObject.GetComponent<XRInteractorLineVisual>();
        leftReticle = leftRay.reticle;

        rightRay = rightcontroller.gameObject.GetComponent<XRInteractorLineVisual>();
        rightReticle = rightRay.reticle;
    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsPressed = CheckIfButtonDown(leftcontroller);
        leftRay.enabled = leftIsPressed;
        leftReticle.SetActive(leftIsPressed);

        bool rightIsPressed = CheckIfButtonDown(rightcontroller);
        rightRay.enabled = rightIsPressed;
        rightReticle.SetActive(rightIsPressed);
    }

    public bool CheckIfButtonDown(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportRayButton, out bool Ispressed, activationThreshold);
        return Ispressed;
    }
}
