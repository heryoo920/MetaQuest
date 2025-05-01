using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_Grab : MonoBehaviour
{
    public Transform Target;
    public Transform OVRController;
    float offSet = 0.3f;

    private void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            Rigidbody rb = Target.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Target.GetComponent<Collider>().isTrigger = true;
            float dist = Vector3.Distance(Target.position, OVRController.position);
            if (dist > offSet)
            {
                Target.position = Vector3.Lerp(Target.position, OVRController.position + OVRController.forward * offSet, 0.1f);
            }
            else
            {
                Target.position = OVRController.position + OVRController.forward * offSet;
                Target.SetParent(OVRController);
            }
        }

        if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger))
        {
            Target.GetComponent<Rigidbody>().AddForce(OVRController.forward * 400);
            Target.GetComponent<Collider>().isTrigger = false;
            Target.SetParent(null);
        }
    }
}
