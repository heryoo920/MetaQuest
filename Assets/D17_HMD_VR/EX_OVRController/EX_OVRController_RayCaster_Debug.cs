using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController_RayCaster_Debug : MonoBehaviour
{
    public EX_OVRController_RayCaster RayCaster;
    public EX_OVR_Debug OVRDebug;

    private void Start()
    {
        if(RayCaster == null)
        {
            RayCaster = GameObject.Find("EX_OVRController_RayCaster").GetComponent<EX_OVRController_RayCaster>();
        }
        if(OVRDebug == null)
        {
            OVRDebug = GameObject.Find("EX_OVRDebug").GetComponent<EX_OVR_Debug>();
        }
    }
    void Update()
    {
        RaycastHit hit = RayCaster.Get_RayHit();
        if(hit.collider != null)
        {
            OVRDebug.Set_Message(hit.collider.name);
        }
        else
        {
            OVRDebug.Set_Message("Point at Objects");
        }
    }
}
